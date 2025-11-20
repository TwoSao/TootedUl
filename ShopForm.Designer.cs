namespace WinFormsApp1
{
    partial class ShopForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCategories = new System.Windows.Forms.ListBox();
            listBoxProducts = new System.Windows.Forms.ListBox();
            pictureBoxProduct = new System.Windows.Forms.PictureBox();
            listBoxCart = new System.Windows.Forms.ListBox();
            numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            btnAddToCart = new System.Windows.Forms.Button();
            btnPurchase = new System.Windows.Forms.Button();
            btnClearCart = new System.Windows.Forms.Button();
            btnBackToWarehouse = new System.Windows.Forms.Button();
            btnBackToMenu = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            SuspendLayout();
            // 
            // listBoxCategories
            // 
            listBoxCategories.BackColor = System.Drawing.Color.White;
            listBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBoxCategories.Font = new System.Drawing.Font("Segoe UI", 11F);
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 20;
            listBoxCategories.Location = new System.Drawing.Point(20, 50);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new System.Drawing.Size(200, 300);
            listBoxCategories.TabIndex = 0;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.BackColor = System.Drawing.Color.White;
            listBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 17;
            listBoxProducts.Location = new System.Drawing.Point(226, 50);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new System.Drawing.Size(350, 289);
            listBoxProducts.TabIndex = 1;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            pictureBoxProduct.Location = new System.Drawing.Point(582, 50);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new System.Drawing.Size(200, 200);
            pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 2;
            pictureBoxProduct.TabStop = false;
            // 
            // listBoxCart
            // 
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 15;
            listBoxCart.Location = new System.Drawing.Point(805, 50);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new System.Drawing.Size(250, 199);
            listBoxCart.TabIndex = 2;
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.Location = new System.Drawing.Point(582, 277);
            numericUpDownQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new System.Drawing.Size(80, 23);
            numericUpDownQty.TabIndex = 3;
            numericUpDownQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)((byte)52)), ((int)((byte)152)), ((int)((byte)219)));
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddToCart.ForeColor = System.Drawing.Color.White;
            btnAddToCart.Location = new System.Drawing.Point(668, 258);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new System.Drawing.Size(110, 42);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "В корзину";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)((byte)46)), ((int)((byte)204)), ((int)((byte)113)));
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnPurchase.ForeColor = System.Drawing.Color.White;
            btnPurchase.Location = new System.Drawing.Point(805, 276);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new System.Drawing.Size(100, 45);
            btnPurchase.TabIndex = 5;
            btnPurchase.Text = "Купить";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)((byte)231)), ((int)((byte)76)), ((int)((byte)60)));
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnClearCart.ForeColor = System.Drawing.Color.White;
            btnClearCart.Location = new System.Drawing.Point(955, 276);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new System.Drawing.Size(100, 45);
            btnClearCart.TabIndex = 6;
            btnClearCart.Text = "Очистить";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnBackToWarehouse
            // 
            btnBackToWarehouse.Location = new System.Drawing.Point(12, 350);
            btnBackToWarehouse.Name = "btnBackToWarehouse";
            btnBackToWarehouse.Size = new System.Drawing.Size(120, 30);
            btnBackToWarehouse.TabIndex = 7;
            btnBackToWarehouse.Text = "К складу";
            btnBackToWarehouse.UseVisualStyleBackColor = true;
            btnBackToWarehouse.Click += btnBackToWarehouse_Click;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new System.Drawing.Point(150, 350);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            btnBackToMenu.TabIndex = 12;
            btnBackToMenu.Text = "Меню";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTotal.Location = new System.Drawing.Point(805, 252);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(74, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Итого: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)44)), ((int)((byte)62)), ((int)((byte)80)));
            label1.Location = new System.Drawing.Point(20, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 25);
            label1.TabIndex = 9;
            label1.Text = "Категории";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(805, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 21);
            label2.TabIndex = 10;
            label2.Text = "Корзина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(582, 258);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 15);
            label3.TabIndex = 11;
            label3.Text = "Количество:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)44)), ((int)((byte)62)), ((int)((byte)80)));
            label4.Location = new System.Drawing.Point(240, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 25);
            label4.TabIndex = 12;
            label4.Text = "Товары";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)236)), ((int)((byte)240)), ((int)((byte)241)));
            ClientSize = new System.Drawing.Size(1081, 400);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(listBoxProducts);
            Controls.Add(listBoxCategories);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnBackToWarehouse);
            Controls.Add(btnClearCart);
            Controls.Add(btnPurchase);
            Controls.Add(btnAddToCart);
            Controls.Add(numericUpDownQty);
            Controls.Add(listBoxCart);
            Controls.Add(pictureBoxProduct);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Магазин";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnClearCart;
        private Button btnBackToWarehouse;
        private Button btnBackToMenu;
        private System.Windows.Forms.Label lblTotal;
        private Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label4;
    }
}