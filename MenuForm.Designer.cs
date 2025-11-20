namespace WinFormsApp1
{
    partial class MenuForm
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

        private void InitializeComponent()
        {
            btnWarehouse = new Button();
            btnShop = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.FromArgb(52, 152, 219);
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Location = new Point(100, 100);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(200, 80);
            btnWarehouse.TabIndex = 0;
            btnWarehouse.Text = "Склад товаров";
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.FromArgb(46, 204, 113);
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnShop.ForeColor = Color.White;
            btnShop.Location = new Point(100, 200);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(200, 80);
            btnShop.TabIndex = 1;
            btnShop.Text = "Магазин";
            btnShop.UseVisualStyleBackColor = false;
            btnShop.Click += btnShop_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(130, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "MENÜÜ";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(400, 350);

            Controls.Add(lblTitle);
            Controls.Add(btnShop);
            Controls.Add(btnWarehouse);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnWarehouse;
        private Button btnShop;
        private Label lblTitle;
    }
}