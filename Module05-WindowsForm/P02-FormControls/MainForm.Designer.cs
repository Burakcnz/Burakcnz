namespace P02_FormControls
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
            label1 = new Label();
            lblYas = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_age = new TextBox();
            cmb_gender = new ComboBox();
            btn_kaydet = new Button();
            lbl_cikti = new Label();
            btn_opensecondform = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblYas.Location = new Point(64, 70);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(45, 25);
            lblYas.TabIndex = 1;
            lblYas.Text = "Yas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Cinsiyet:";
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.Menu;
            txt_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = SystemColors.InfoText;
            txt_name.Location = new Point(115, 24);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(197, 33);
            txt_name.TabIndex = 0;
            // 
            // txt_age
            // 
            txt_age.BackColor = SystemColors.Menu;
            txt_age.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age.ForeColor = SystemColors.InfoText;
            txt_age.Location = new Point(115, 68);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(51, 33);
            txt_age.TabIndex = 1;
            
            // 
            // cmb_gender
            // 
            cmb_gender.BackColor = SystemColors.Menu;
            cmb_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            cmb_gender.Location = new Point(115, 112);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(121, 33);
            cmb_gender.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            btn_kaydet.BackColor = SystemColors.ActiveCaption;
            btn_kaydet.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kaydet.Location = new Point(344, 24);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(163, 121);
            btn_kaydet.TabIndex = 3;
            btn_kaydet.Text = "KAYDET";
            btn_kaydet.UseVisualStyleBackColor = false;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // lbl_cikti
            // 
            lbl_cikti.AutoSize = true;
            lbl_cikti.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cikti.Location = new Point(12, 194);
            lbl_cikti.Name = "lbl_cikti";
            lbl_cikti.Size = new Size(0, 30);
            lbl_cikti.TabIndex = 4;
            // 
            // btn_opensecondform
            // 
            btn_opensecondform.Location = new Point(394, 172);
            btn_opensecondform.Name = "btn_opensecondform";
            btn_opensecondform.Size = new Size(113, 35);
            btn_opensecondform.TabIndex = 5;
            btn_opensecondform.Text = "open second form";
            btn_opensecondform.UseVisualStyleBackColor = true;
            btn_opensecondform.Click += btn_opensecondform_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(538, 258);
            Controls.Add(btn_opensecondform);
            Controls.Add(lbl_cikti);
            Controls.Add(btn_kaydet);
            Controls.Add(cmb_gender);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblYas);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Controls App";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblYas;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_age;
        private ComboBox cmb_gender;
        private Button btn_kaydet;
        private Label lbl_cikti;
        private Button btn_opensecondform;
    }
}
