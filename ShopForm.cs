using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ShopForm : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=toodeDB;Integrated Security=True");
        
        private List<CartItem> cart = new List<CartItem>();
        private decimal totalAmount = 0;

        public ShopForm()
        {
            InitializeComponent();
            LoadCategories();
            SetEstonianTexts();
        }

        private void SetEstonianTexts()
        {
            this.Text = "Pood";
            label1.Text = "Kategooriad";
            label4.Text = "Tooted";
            label2.Text = "Ostukorv";
            label3.Text = "Kogus:";
            btnAddToCart.Text = "Korvi";
            btnPurchase.Text = "Osta";
            btnClearCart.Text = "Puhasta";
            btnBackToWarehouse.Text = "Lattu";
            btnBackToMenu.Text = "Menüü";
            lblTotal.Text = "Kokku: 0";
        }

        private void LoadCategories()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                listBoxCategories.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    listBoxCategories.Items.Add(new CategoryItem
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Kategooria_nimetus"].ToString()
                    });
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT Id, Toodenimetus, Kogus, Hind, Bpilt FROM Toodetabel WHERE Kategooriad = @catId AND Kogus > 0", connect);
                adapter.SelectCommand.Parameters.AddWithValue("@catId", categoryId);
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                listBoxProducts.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    listBoxProducts.Items.Add(new ProductItem
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Toodenimetus"].ToString(),
                        Quantity = Convert.ToInt32(row["Kogus"]),
                        Price = Convert.ToDecimal(row["Hind"]),
                        Image = row["Bpilt"] as byte[]
                    });
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки товаров: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Vali toode!");
                return;
            }

            var product = (ProductItem)listBoxProducts.SelectedItem;
            
            if (numericUpDownQty.Value > product.Quantity)
            {
                MessageBox.Show($"Pole piisavalt kaupa! Saadaval: {product.Quantity}");
                return;
            }

            var existingItem = cart.FirstOrDefault(x => x.ProductId == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += (int)numericUpDownQty.Value;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Price = product.Price,
                    Quantity = (int)numericUpDownQty.Value
                });
            }

            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            listBoxCart.Items.Clear();
            totalAmount = 0;

            foreach (var item in cart)
            {
                decimal itemTotal = item.Price * item.Quantity;
                totalAmount += itemTotal;
                listBoxCart.Items.Add($"{item.ProductName} x{item.Quantity} = {itemTotal:C}");
            }

            lblTotal.Text = $"Kokku: {totalAmount:C}";
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Käru on tühi!");
                return;
            }

            try
            {
                connect.Open();
                SqlTransaction transaction = connect.BeginTransaction();

                foreach (var item in cart)
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Toodetabel SET Kogus = Kogus - @qty WHERE Id = @id AND Kogus >= @qty", 
                        connect, transaction);
                    cmd.Parameters.AddWithValue("@qty", item.Quantity);
                    cmd.Parameters.AddWithValue("@id", item.ProductId);
                    
                    int affected = cmd.ExecuteNonQuery();
                    if (affected == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Pole piisavalt kaupa '{item.ProductName}' laos!");
                        connect.Close();
                        return;
                    }
                }

                transaction.Commit();
                connect.Close();

                MessageBox.Show($"Ost sooritatud! Kogusumma: {totalAmount:C}");
                cart.Clear();
                UpdateCartDisplay();
                if (listBoxCategories.SelectedItem != null)
                {
                    var category = (CategoryItem)listBoxCategories.SelectedItem;
                    LoadProductsByCategory(category.Id);
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Viga ostmisel: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            UpdateCartDisplay();
            MessageBox.Show("Korv on tühjendatud!");
        }

        private void btnBackToWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 warehouseForm = new Form1();
            warehouseForm.Show();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                var category = (CategoryItem)listBoxCategories.SelectedItem;
                LoadProductsByCategory(category.Id);
                pictureBoxProduct.Image = null;
            }
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                var product = (ProductItem)listBoxProducts.SelectedItem;
                if (product.Image != null && product.Image.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(product.Image))
                        {
                            pictureBoxProduct.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        pictureBoxProduct.Image = null;
                    }
                }
                else
                {
                    pictureBoxProduct.Image = null;
                }
            }
        }
    }

    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class CategoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }

    public class ProductItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public override string ToString() => $"{Name}\n{Price:C} | Ост.: {Quantity}";
    }
}