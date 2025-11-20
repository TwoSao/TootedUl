using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=toodeDB;Integrated Security=True");

        SqlCommand command;
        SqlDataAdapter adapter_toode, adapter_kategooria;

        OpenFileDialog open;
        byte[] imageData;

        public Form1()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
            SetEstonianTexts();
        }

        private void SetEstonianTexts()
        {
            this.Text = "Ladu";
            toodeLbl.Text = "Toode:";
            kogusLbl.Text = "Kogus:";
            hindLbl.Text = "Hind:";
            kategorLbl.Text = "Kategooriad:";
            lisakategorBtn.Text = "Lisa\nkategooriat";
            kustutakategorBtn.Text = "Kustuta\nkategooriat";
            lisaBtn.Text = "Lisa";
            uuendaBtn.Text = "Uuenda";
            KustutaBtn.Text = "Kustuta";
            puhastaBtn.Text = "Puhasta";
            otsifailBtn.Text = "Otsi\nfail";
            poodBtn.Text = "Pood";
        }
        int Id = 0;

        // === ДОБАВЛЕНИЕ КАТЕГОРИИ ===
        private void lisaBtn_Click(object sender, EventArgs e)
        {
            bool olemas = kat_box.Items.Cast<object>().Any(item => item.ToString() == kat_box.Text);

            if (!olemas && !string.IsNullOrWhiteSpace(kat_box.Text))
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)", connect);
                    command.Parameters.AddWithValue("@kat", kat_box.Text);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Kategooria lisatud!");
                    NaitaKategooriad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    if (connect.State == ConnectionState.Open) connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Sama kategooria on juba olemas või väli on tühi!");
            }
        }

        // === ВЫБОР ФАЙЛА ===
        private void otsifailBtn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\source\repos\WinFormsApp1\images";
            open.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string imagesFolder = Path.Combine(projectPath, "images");

                // Создаём папку, если её ещё нет
                Directory.CreateDirectory(imagesFolder);

                string destPath = Path.Combine(imagesFolder, toodeTextB.Text + Path.GetExtension(open.FileName));

                try
                {
                    File.Copy(open.FileName, destPath, true);
                    toode_pb.Image = Image.FromFile(destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при копировании файла: " + ex.Message);
                }
            }
        }

        // === ДОБАВЛЕНИЕ ТОВАРА ===
        private void lisaBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toodeTextB.Text) ||
                string.IsNullOrWhiteSpace(kogusTextB.Text) ||
                string.IsNullOrWhiteSpace(hindTextB.Text))
            {
                MessageBox.Show("Täida kõik väljad!");
                return;
            }

            try
            {
                connect.Open();

                command = new SqlCommand("SELECT Id FROM Kategooria WHERE Kategooria_nimetus = @kat", connect);
                command.Parameters.AddWithValue("@kat", kat_box.Text);
                object result = command.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Категория не найдена!");
                    connect.Close();
                    return;
                }

                int katId = Convert.ToInt32(result);

                if (!int.TryParse(kogusTextB.Text, out int kogus) || !int.TryParse(hindTextB.Text, out int hind))
                {
                    MessageBox.Show("Введите числовые значения в поля 'Количество' и 'Цена'");
                    connect.Close();
                    return;
                }

                command = new SqlCommand(
                    "INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Bpilt, Kategooriad) " +
                    "VALUES (@toode, @kogus, @hind, @pilt, @bpilt, @kat)", connect);

                command.Parameters.AddWithValue("@toode", toodeTextB.Text);
                command.Parameters.AddWithValue("@kogus", kogusTextB.Text);
                command.Parameters.AddWithValue("@hind", hindTextB.Text);

                if (open != null && !string.IsNullOrEmpty(open.FileName))
                {
                    string extension = Path.GetExtension(open.FileName);
                    command.Parameters.AddWithValue("@pilt", toodeTextB.Text + extension);
                    byte[] imageData = File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@bpilt", imageData);
                }
                else
                {
                    command.Parameters.AddWithValue("@pilt", DBNull.Value);
                    command.Parameters.AddWithValue("@bpilt", DBNull.Value);
                }

                command.Parameters.AddWithValue("@kat", katId);

                int rows = command.ExecuteNonQuery();
                MessageBox.Show("Toode edukalt lisatud!");

                connect.Close();
                NaitaAndmed();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // === ПОКАЗ КАТЕГОРИЙ ===
        private void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
            DataTable tabel_kat = new DataTable();
            adapter_kategooria.Fill(tabel_kat);
            connect.Close();

            kat_box.Items.Clear();
            foreach (DataRow item in tabel_kat.Rows)
            {
                kat_box.Items.Add(item["Kategooria_nimetus"].ToString());
            }
        }

        // === УДАЛЕНИЕ КАТЕГОРИИ ===
        private void kustutakategorBtn_Click(object sender, EventArgs e)
        {
            if (kat_box.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Kategooria WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", kat_box.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Категория удалена!");
                    NaitaKategooriad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении категории: " + ex.Message);
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите категорию для удаления!");
            }
        }

        // === ОТОБРАЖЕНИЕ ДАННЫХ ===
        public void NaitaAndmed()
        {
            connect.Open();

            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter(
                "SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, T.Bpilt, " +
                "K.Kategooria_nimetus AS Kategooria " +
                "FROM Toodetabel T INNER JOIN Kategooria K ON T.Kategooriad = K.Id", connect);

            adapter_toode.Fill(dt_toode);
            connect.Close();

            dataGridView1.DataSource = dt_toode;

            if (!dataGridView1.Columns.Contains("Bpilt"))
                dataGridView1.Columns.Add("Bpilt", "Bpilt");

            dataGridView1.Columns["Bpilt"].Visible = true
                ;
        }

        // === Показ картинки при наведении ===
        private Form popupForm;

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Проверяем, что наведение именно на столбец "Bpilt"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Bpilt")
                {
                    var cellValue = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value;
                    if (cellValue is byte[] data && data.Length > 0)
                    {
                        using MemoryStream ms = new MemoryStream(data);
                        Image img = Image.FromStream(ms);
                        ShowPopupImage(img, e.RowIndex, e.ColumnIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            popupForm?.Close();
        }

        private void ShowPopupImage(Image img, int rowIndex, int colIndex)
        {
            popupForm?.Close(); // чтобы не открывались дубликаты

            popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                Size = new Size(200, 200),
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                BackColor = Color.Black,
                Opacity = 0.95
            };

            PictureBox pb = new PictureBox
            {
                Image = img,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            popupForm.Controls.Add(pb);

            // Определяем позицию рядом с ячейкой
            Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, true);
            Point cellLocation = dataGridView1.PointToScreen(cellRect.Location);
            popupForm.Location = new Point(cellLocation.X + cellRect.Width + 10, cellLocation.Y);

            popupForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0)
            {
                FillFieldsFromSelectedRow();
            }
        }

        private void FillFieldsFromSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                
                toodeTextB.Text = row.Cells["Toodenimetus"].Value?.ToString() ?? "";
                kogusTextB.Text = row.Cells["Kogus"].Value?.ToString() ?? "";
                hindTextB.Text = row.Cells["Hind"].Value?.ToString() ?? "";
                
                // Устанавливаем категорию
                string kategooria = row.Cells["Kategooria"].Value?.ToString();
                if (!string.IsNullOrEmpty(kategooria))
                {
                    kat_box.Text = kategooria;
                }
                
                // Отображаем изображение
                if (row.Cells["Bpilt"].Value is byte[] imageData && imageData.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                            toode_pb.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        toode_pb.Image = null;
                    }
                }
                else
                {
                    toode_pb.Image = null;
                }
            }
        }

        private void puhastaBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            toodeTextB.Clear();
            kogusTextB.Clear();
            hindTextB.Clear();
            kat_box.SelectedIndex = -1;
            toode_pb.Image = null;
            
            // Снимаем выделение с таблицы
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void KustutaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Получаем ID выбранного товара
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show(
                    "Вы уверены, что хотите удалить этот товар?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Toodetabel WHERE Id = @Id", connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        connect.Open();
                        int rows = cmd.ExecuteNonQuery();
                        connect.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("Товар успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NaitaAndmed();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Товар не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void uuendaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для обновления!");
                return;
            }

            try
            {
                var row = dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                string toode = row.Cells["Toodenimetus"].Value?.ToString() ?? "";
                int kogus = Convert.ToInt32(row.Cells["Kogus"].Value);
                decimal hind = Convert.ToDecimal(row.Cells["Hind"].Value);
                string kategooria = row.Cells["Kategooria"].Value?.ToString() ?? "";
        
                connect.Open();
        
                // Получаем ID категории
                int katId = 0;
                if (!string.IsNullOrEmpty(kategooria))
                {
                    command = new SqlCommand("SELECT Id FROM Kategooria WHERE Kategooria_nimetus = @kat", connect);
                    command.Parameters.AddWithValue("@kat", kategooria);
                    katId = Convert.ToInt32(command.ExecuteScalar());
                }

                // Обновляем товар
                command = new SqlCommand(
                    "UPDATE Toodetabel SET Toodenimetus=@toode, Kogus=@kogus, Hind=@hind, Kategooriad=@kat WHERE Id=@Id", 
                    connect);
                command.Parameters.AddWithValue("@Id", selectedId);
                command.Parameters.AddWithValue("@toode", toode);
                command.Parameters.AddWithValue("@kogus", kogus);
                command.Parameters.AddWithValue("@hind", hind);
                command.Parameters.AddWithValue("@kat", katId);
        
                command.ExecuteNonQuery();
                connect.Close();
        
                MessageBox.Show("Товар успешно обновлён!");
                NaitaAndmed();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void poodBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
        
    }
}
