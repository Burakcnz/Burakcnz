namespace P03_SqlWithNorthwind
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategories = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            dgvProduct = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Update = new Button();
            btn_NewSave = new Button();
            cmb_ProductCategories = new ComboBox();
            txt_ProductStock = new TextBox();
            txt_ProductPrice = new TextBox();
            txt_ProductName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_DeleteProduct = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Items.AddRange(new object[] { "" });
            cmbCategories.Location = new Point(73, 7);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(142, 23);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategoriler";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(dgvProduct);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1301, 337);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbCategories);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1080, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 50);
            panel1.TabIndex = 4;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(3, 69);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(1295, 265);
            dgvProduct.TabIndex = 4;
            dgvProduct.CellEnter += dgvProduct_CellEnter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_DeleteProduct);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(btn_NewSave);
            groupBox2.Controls.Add(cmb_ProductCategories);
            groupBox2.Controls.Add(txt_ProductStock);
            groupBox2.Controls.Add(txt_ProductPrice);
            groupBox2.Controls.Add(txt_ProductName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 268);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Ürün";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(112, 189);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(100, 30);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Güncelle";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_NewSave
            // 
            btn_NewSave.Location = new Point(6, 189);
            btn_NewSave.Name = "btn_NewSave";
            btn_NewSave.Size = new Size(100, 30);
            btn_NewSave.TabIndex = 8;
            btn_NewSave.Text = "Yeni Ürün";
            btn_NewSave.UseVisualStyleBackColor = true;
            btn_NewSave.Click += btn_NewSave_Click;
            // 
            // cmb_ProductCategories
            // 
            cmb_ProductCategories.FormattingEnabled = true;
            cmb_ProductCategories.Location = new Point(83, 143);
            cmb_ProductCategories.Name = "cmb_ProductCategories";
            cmb_ProductCategories.Size = new Size(242, 23);
            cmb_ProductCategories.TabIndex = 7;
            // 
            // txt_ProductStock
            // 
            txt_ProductStock.Location = new Point(83, 103);
            txt_ProductStock.Name = "txt_ProductStock";
            txt_ProductStock.Size = new Size(242, 23);
            txt_ProductStock.TabIndex = 6;
            // 
            // txt_ProductPrice
            // 
            txt_ProductPrice.Location = new Point(83, 65);
            txt_ProductPrice.Name = "txt_ProductPrice";
            txt_ProductPrice.Size = new Size(242, 23);
            txt_ProductPrice.TabIndex = 5;
            // 
            // txt_ProductName
            // 
            txt_ProductName.Location = new Point(83, 28);
            txt_ProductName.Name = "txt_ProductName";
            txt_ProductName.Size = new Size(242, 23);
            txt_ProductName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 146);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 106);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 2;
            label4.Text = "Stok Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "Fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 31);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı:";
            // 
            // btn_DeleteProduct
            // 
            btn_DeleteProduct.Location = new Point(218, 189);
            btn_DeleteProduct.Name = "btn_DeleteProduct";
            btn_DeleteProduct.Size = new Size(100, 30);
            btn_DeleteProduct.TabIndex = 10;
            btn_DeleteProduct.Text = "Sil";
            btn_DeleteProduct.UseVisualStyleBackColor = true;
            btn_DeleteProduct.Click += btn_DeleteProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1301, 623);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Takip Uygulaması";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbCategories;
        private Label label1;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dgvProduct;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private Button btn_NewSave;
        private ComboBox cmb_ProductCategories;
        private TextBox txt_ProductStock;
        private TextBox txt_ProductPrice;
        private TextBox txt_ProductName;
        private Label label5;
        private Label label4;
        private Button btn_Update;
        private Button btn_DeleteProduct;
    }
}
