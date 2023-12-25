namespace odev
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
            dgvProduct = new DataGridView();
            cmbCategories = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Bottom;
            dgvProduct.Location = new Point(0, 166);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(800, 284);
            dgvProduct.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(12, 42);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(121, 23);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategoriler";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(dgvProduct);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private ComboBox cmbCategories;
        private Label label1;
    }
}
