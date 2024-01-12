using odev.Entities;
using P03_SqlWithNorthwind;
using System.Data;

namespace odev
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillCategories();
            FillProducts();
        }
        private void FillProducts()
        {
            NorthwindDAL northwindDAL = new NorthwindDAL();
            DataTable products = northwindDAL.GetAllProducts();
            

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
           

        }
    }
}
