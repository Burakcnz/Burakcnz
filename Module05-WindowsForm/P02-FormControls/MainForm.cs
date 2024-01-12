namespace P02_FormControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string age = txt_age.Text;
            string gender = cmb_gender.Text;

            if (name.Trim() != "" && age.Trim() != "" && gender.Trim() != "")
            {
                lbl_cikti.Text = "Lütfen deðerleri girin!";
            }
            else
            {
                lbl_cikti.Text = $"Merhaba {name} yaþýnýz {age}, cinsiyetiniz {gender}.";
            }



        }

        //private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        //}

        private void btn_opensecondform_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();
            //secondForm.Show();           

        }
    }
}
