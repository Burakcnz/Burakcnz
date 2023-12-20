namespace P02_FormControls
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            btn_addCategory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_addCategory
            // 
            btn_addCategory.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addCategory.Location = new Point(245, 111);
            btn_addCategory.Name = "btn_addCategory";
            btn_addCategory.Size = new Size(326, 141);
            btn_addCategory.TabIndex = 0;
            btn_addCategory.Text = "add category";
            btn_addCategory.UseVisualStyleBackColor = true;
            btn_addCategory.Click += btn_addCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 53);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "second form";
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_addCategory);
            Name = "SecondForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addCategory;
        private Label label1;
    }
}