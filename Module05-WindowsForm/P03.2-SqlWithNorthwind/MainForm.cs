using P03_SqlWithNorthwind.Entities;
using System.Data;

namespace P03_SqlWithNorthwind
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillCategories();

        }
        private void FillProducts()
        {
            NorthwindDAL northwindDAL = new NorthwindDAL();
            DataTable products = northwindDAL.GetAllProducts();
            dgvProduct.DataSource = products;
            dgvProduct.Columns[0].Width = 50;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[1].Width = 500;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].DefaultCellStyle.Format = "c";
        }



        private void FillCategories()
        {
            NorthwindDAL northwindDAL = new NorthwindDAL();
            List<Category> categories = northwindDAL.GetAllCategories();
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";


        }



        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbCategories.SelectedValue.ToString().Contains("Category"))
            {
                FillProductByCategoryID((int)cmbCategories.SelectedValue);
            }
        }

        private void FillProductByCategoryID(int id)
        {

            NorthwindDAL northwindDAL = new NorthwindDAL();
            northwindDAL.GetAllProductsByCategoryId(id);
            //DataTable products = northwindDAL.GetAllProductsByCategoryId(id);

            if (id == 0)
            {
                DataTable products = northwindDAL.GetAllProducts();
                dgvProduct.DataSource = products;
            }
            else
            {
                List<Product> products = northwindDAL.GetAllProductsByCategoryId(id);
                dgvProduct.DataSource = products;
            }
            dgvProduct.Columns[0].Width = 50;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[1].Width = 500;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].DefaultCellStyle.Format = "c";

        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            FillProducts();
            cmbCategories.SelectedIndex = 0;
        }
    }
}
