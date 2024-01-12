using P03_SqlWithNorthwind.Entities;
using P03_SqlWithNorthwind.Models;
using System.Data;

namespace P03_SqlWithNorthwind
{
    public partial class MainForm : Form
    {
        private int rowIndex = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillCategories();
            dgvProduct.Columns[5].Visible = false;

        }
        private void FillProducts()
        {

            DataTable products = NorthwindDAL.GetAllProducts();
            dgvProduct.DataSource = products;
            //dgvProduct.Rows[rowIndex].Selected = true;
            dgvProduct.Columns[0].Width = 50;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[1].Width = 500;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[3].DefaultCellStyle.Format = "c";
        }



        private void FillCategories()
        {

            LinkedList<Category> categories = NorthwindDAL.GetAllCategories();

            cmb_ProductCategories.DataSource = categories.ToList();
            cmb_ProductCategories.DisplayMember = "Name";
            cmb_ProductCategories.ValueMember = "Id";
            cmb_ProductCategories.SelectedIndex = 0;

            categories.AddFirst(new Category { Id = 0, Name = "Tümü" });
            cmbCategories.DataSource = categories.ToList();
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
            cmbCategories.SelectedIndex = 0;




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

            if (id == 0)
            {
                DataTable products = NorthwindDAL.GetAllProducts();
                dgvProduct.DataSource = products;
            }
            else
            {
                List<Product> products = NorthwindDAL.GetAllProductsByCategoryId(id);
                dgvProduct.DataSource = products;
                dgvProduct.Columns[1].HeaderText = "Ürün";
                dgvProduct.Columns[2].HeaderText = "Kategori";
                dgvProduct.Columns[3].HeaderText = "Fiyat";
                dgvProduct.Columns[4].HeaderText = "Stok";

            }
            dgvProduct.Columns[0].Width = 50;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[1].Width = 500;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[4].DefaultCellStyle.Format = "c";

        }


        private void FormCleaner()
        {
            txt_ProductName.Text = string.Empty;
            txt_ProductPrice.Text = string.Empty;
            txt_ProductStock.Text = string.Empty;
            cmb_ProductCategories.SelectedIndex = 0;
            txt_ProductName.Focus();
        }

        private void SaveProducts()
        {
            AddProductModel addProductModel = new AddProductModel()
            {
                Name = txt_ProductName.Text,
                Price = Convert.ToDecimal(txt_ProductPrice.Text),
                Stock = Convert.ToInt32(txt_ProductStock.Text),
                CategoryID = Convert.ToInt32(cmb_ProductCategories.SelectedValue)
            };

            NorthwindDAL.CreateProduct(addProductModel);
        }

        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_ProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txt_ProductPrice.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txt_ProductStock.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            cmb_ProductCategories.SelectedValue = dgvProduct.CurrentRow.Cells[5].Value;
        }

        private void btn_NewSave_Click(object sender, EventArgs e)
        {
            if (btn_NewSave.Text == "Yeni Ürün")
            {
                FormCleaner();
                btn_NewSave.Text = "Kaydet";
                btn_Update.Enabled = false;
            }
            else
            {
                SaveProducts();
                FillProducts();
                btn_NewSave.Text = "Yeni Ürün";
                btn_Update.Enabled = true;
            }




        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
            Product product = new Product()
            {
                Id = id,
                Name = txt_ProductName.Text,
                Price = Convert.ToDecimal(txt_ProductPrice.Text),
                Stock = Convert.ToInt32(txt_ProductStock.Text),
                CategoryId = Convert.ToInt32(cmb_ProductCategories.SelectedValue)
            };
            NorthwindDAL.UpdateProduct(product);
            FillProducts();

        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
            NorthwindDAL.DeleteProduct(id);
            FillProducts();
        }
    }
}
