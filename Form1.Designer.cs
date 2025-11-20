namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toode_pb = new System.Windows.Forms.PictureBox();
            toodeLbl = new System.Windows.Forms.Label();
            kogusLbl = new System.Windows.Forms.Label();
            hindLbl = new System.Windows.Forms.Label();
            kategorLbl = new System.Windows.Forms.Label();
            kogusTextB = new System.Windows.Forms.TextBox();
            hindTextB = new System.Windows.Forms.TextBox();
            toodeTextB = new System.Windows.Forms.TextBox();
            lisakategorBtn = new System.Windows.Forms.Button();
            kustutakategorBtn = new System.Windows.Forms.Button();
            lisaBtn = new System.Windows.Forms.Button();
            uuendaBtn = new System.Windows.Forms.Button();
            KustutaBtn = new System.Windows.Forms.Button();
            puhastaBtn = new System.Windows.Forms.Button();
            otsifailBtn = new System.Windows.Forms.Button();
            poodBtn = new System.Windows.Forms.Button();
            kat_box = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)toode_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toode_pb
            // 
            toode_pb.BackColor = System.Drawing.SystemColors.ControlDark;
            toode_pb.Location = new System.Drawing.Point(513, 9);
            toode_pb.Name = "toode_pb";
            toode_pb.Size = new System.Drawing.Size(557, 335);
            toode_pb.TabIndex = 0;
            toode_pb.TabStop = false;
            // 
            // toodeLbl
            // 
            toodeLbl.AutoSize = true;
            toodeLbl.Location = new System.Drawing.Point(12, 12);
            toodeLbl.Name = "toodeLbl";
            toodeLbl.Size = new System.Drawing.Size(43, 15);
            toodeLbl.TabIndex = 1;
            toodeLbl.Text = "Товар:";
            // 
            // kogusLbl
            // 
            kogusLbl.AutoSize = true;
            kogusLbl.Location = new System.Drawing.Point(9, 41);
            kogusLbl.Name = "kogusLbl";
            kogusLbl.Size = new System.Drawing.Size(75, 15);
            kogusLbl.TabIndex = 2;
            kogusLbl.Text = "Количество:";
            // 
            // hindLbl
            // 
            hindLbl.AutoSize = true;
            hindLbl.Location = new System.Drawing.Point(12, 70);
            hindLbl.Name = "hindLbl";
            hindLbl.Size = new System.Drawing.Size(38, 15);
            hindLbl.TabIndex = 3;
            hindLbl.Text = "Цена:";
            // 
            // kategorLbl
            // 
            kategorLbl.AutoSize = true;
            kategorLbl.Location = new System.Drawing.Point(9, 99);
            kategorLbl.Name = "kategorLbl";
            kategorLbl.Size = new System.Drawing.Size(67, 15);
            kategorLbl.TabIndex = 4;
            kategorLbl.Text = "Категории:";
            // 
            // kogusTextB
            // 
            kogusTextB.Location = new System.Drawing.Point(89, 38);
            kogusTextB.Name = "kogusTextB";
            kogusTextB.Size = new System.Drawing.Size(139, 23);
            kogusTextB.TabIndex = 5;
            // 
            // hindTextB
            // 
            hindTextB.Location = new System.Drawing.Point(89, 67);
            hindTextB.Name = "hindTextB";
            hindTextB.Size = new System.Drawing.Size(139, 23);
            hindTextB.TabIndex = 6;
            // 
            // toodeTextB
            // 
            toodeTextB.Location = new System.Drawing.Point(89, 9);
            toodeTextB.Name = "toodeTextB";
            toodeTextB.Size = new System.Drawing.Size(139, 23);
            toodeTextB.TabIndex = 8;
            // 
            // lisakategorBtn
            // 
            lisakategorBtn.Location = new System.Drawing.Point(11, 152);
            lisakategorBtn.Name = "lisakategorBtn";
            lisakategorBtn.Size = new System.Drawing.Size(88, 62);
            lisakategorBtn.TabIndex = 9;
            lisakategorBtn.Text = "Добавить \nкатегорию";
            lisakategorBtn.UseVisualStyleBackColor = true;
            lisakategorBtn.Click += lisaBtn_Click;
            // 
            // kustutakategorBtn
            // 
            kustutakategorBtn.Location = new System.Drawing.Point(105, 152);
            kustutakategorBtn.Name = "kustutakategorBtn";
            kustutakategorBtn.Size = new System.Drawing.Size(88, 62);
            kustutakategorBtn.TabIndex = 10;
            kustutakategorBtn.Text = "Удалить \nкатегорию";
            kustutakategorBtn.UseVisualStyleBackColor = true;
            kustutakategorBtn.Click += kustutakategorBtn_Click;
            // 
            // lisaBtn
            // 
            lisaBtn.Location = new System.Drawing.Point(9, 392);
            lisaBtn.Name = "lisaBtn";
            lisaBtn.Size = new System.Drawing.Size(88, 33);
            lisaBtn.TabIndex = 11;
            lisaBtn.Text = "Добавить";
            lisaBtn.UseVisualStyleBackColor = true;
            lisaBtn.Click += lisaBtn_Click_1;
            // 
            // uuendaBtn
            // 
            uuendaBtn.Location = new System.Drawing.Point(105, 392);
            uuendaBtn.Name = "uuendaBtn";
            uuendaBtn.Size = new System.Drawing.Size(88, 33);
            uuendaBtn.TabIndex = 12;
            uuendaBtn.Text = "Обновить";
            uuendaBtn.UseVisualStyleBackColor = true;
            uuendaBtn.Click += uuendaBtn_Click;
            // 
            // KustutaBtn
            // 
            KustutaBtn.Location = new System.Drawing.Point(200, 392);
            KustutaBtn.Name = "KustutaBtn";
            KustutaBtn.Size = new System.Drawing.Size(88, 33);
            KustutaBtn.TabIndex = 13;
            KustutaBtn.Text = "Удалить";
            KustutaBtn.UseVisualStyleBackColor = true;
            KustutaBtn.Click += KustutaBtn_Click;
            // 
            // puhastaBtn
            // 
            puhastaBtn.Location = new System.Drawing.Point(294, 392);
            puhastaBtn.Name = "puhastaBtn";
            puhastaBtn.Size = new System.Drawing.Size(88, 33);
            puhastaBtn.TabIndex = 14;
            puhastaBtn.Text = "Очистить";
            puhastaBtn.UseVisualStyleBackColor = true;
            puhastaBtn.Click += puhastaBtn_Click;
            // 
            // otsifailBtn
            // 
            otsifailBtn.Location = new System.Drawing.Point(513, 353);
            otsifailBtn.Name = "otsifailBtn";
            otsifailBtn.Size = new System.Drawing.Size(88, 33);
            otsifailBtn.TabIndex = 15;
            otsifailBtn.Text = "Выбрать \nфайл";
            otsifailBtn.UseVisualStyleBackColor = true;
            otsifailBtn.Click += otsifailBtn_Click;
            // 
            // poodBtn
            // 
            poodBtn.Location = new System.Drawing.Point(689, 350);
            poodBtn.Name = "poodBtn";
            poodBtn.Size = new System.Drawing.Size(88, 33);
            poodBtn.TabIndex = 20;
            poodBtn.Text = "Магазин";
            poodBtn.UseVisualStyleBackColor = true;
            poodBtn.Click += poodBtn_Click;
            // 
            // kat_box
            // 
            kat_box.FormattingEnabled = true;
            kat_box.Location = new System.Drawing.Point(89, 99);
            kat_box.Name = "kat_box";
            kat_box.Size = new System.Drawing.Size(139, 23);
            kat_box.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 459);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(1047, 156);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(783, 350);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 33);
            button1.TabIndex = 24;
            button1.Text = "Menüü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1094, 627);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(kat_box);
            Controls.Add(poodBtn);
            Controls.Add(otsifailBtn);
            Controls.Add(puhastaBtn);
            Controls.Add(KustutaBtn);
            Controls.Add(uuendaBtn);
            Controls.Add(lisaBtn);
            Controls.Add(kustutakategorBtn);
            Controls.Add(lisakategorBtn);
            Controls.Add(toodeTextB);
            Controls.Add(hindTextB);
            Controls.Add(kogusTextB);
            Controls.Add(kategorLbl);
            Controls.Add(hindLbl);
            Controls.Add(kogusLbl);
            Controls.Add(toodeLbl);
            Controls.Add(toode_pb);
            Text = "Склад товаров";
            ((System.ComponentModel.ISupportInitialize)toode_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        #endregion

        private PictureBox toode_pb;
        private Label toodeLbl;
        private Label kogusLbl;
        private Label hindLbl;
        private Label kategorLbl;
        private TextBox kogusTextB;
        private TextBox hindTextB;
        private TextBox toodeTextB;
        private Button lisakategorBtn;
        private Button kustutakategorBtn;
        private Button lisaBtn;
        private Button uuendaBtn;
        private Button KustutaBtn;
        private Button puhastaBtn;
        private Button otsifailBtn;
        private System.Windows.Forms.Button poodBtn;
        private ComboBox kat_box;
        private DataGridView dataGridView1;
    }
}
