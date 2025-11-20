namespace WinFormsApp1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
            SetEstonianTexts();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 warehouseForm = new Form1();
            warehouseForm.FormClosed += (s, e) => this.Show();
            warehouseForm.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.FormClosed += (s, e) => this.Show();
            shopForm.Show();
        }

        private void SetEstonianTexts()
        {
            lblTitle.Text = "MENÜÜ";
            btnWarehouse.Text = "Ladu";
            btnShop.Text = "Pood";
        }
    }
}