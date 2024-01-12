using odev.Entities;
using System.Data;
using System.Data.SqlClient;

namespace P03_SqlWithNorthwind
{
    internal class NorthwindDAL
    {
        SqlConnection connection;

        public NorthwindDAL()
        {
            connection = CreateConnection();
        }

        private SqlConnection CreateConnection()
        {
            string serverName = "DESKTOP-3O41JPC";
            string dbName = "Northwind";
            string connectionString = $"Server={serverName};Database={dbName};Trusted_Connection=true;TrustServerCertificate=true";
            return new SqlConnection(connectionString);


        }
        private void OpenDataBase()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
        }
        private void CloseDataBase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable GetAllProducts()
        {
            string queryString = @"
            SELECT
	           p.ProductID AS [ID],
               p.ProductName AS [Ürün],
               c.CategoryName AS [Kategori]             
             FROM Products p 
	          JOIN Categories c 
		       ON p.CategoryID=c.CategoryID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, connection);
            DataTable dataTable = new DataTable();
            OpenDataBase();
            sqlDataAdapter.Fill(dataTable);
            CloseDataBase();
            return dataTable;
        }
        public List<Category> GetAllCategories()
        {
            string queryString = @"
               SELECT
                 c.CategoryID,
                 c.CategoryName,
                c.Description
               FROM Categories c";
            SqlCommand cmd = new SqlCommand(queryString, connection);
            OpenDataBase();
            SqlDataReader dataReader = cmd.ExecuteReader();
            List<Category> categories = new List<Category>();
            Category category;
            categories.Add(new Category { Id = 0, Name = "Tümü" });
            while (dataReader.Read() == true)
            {
                category = new Category()
                {

                    Id = (int)dataReader["CategoryID"],
                    Name = (string)dataReader["CategoryName"],
                    Description = (string)dataReader["Description"]

                };
                categories.Add(category);
            }
            CloseDataBase();
            return categories;

        }

        public List<Product> GetAllProductsByCategoryId(int id)
        {
            string queryString = @$"
                SELECT
	                p.ProductID AS [ID],
	                p.ProductName AS [Ürün],
	                c.CategoryName AS [Kategori]	               
                FROM Products p 
	                JOIN Categories c 
		                ON p.CategoryID=c.CategoryID
		        WHERE c.CategoryID = @pId";

            SqlCommand cmd = new SqlCommand(queryString, connection);
            cmd.Parameters.AddWithValue("@pId", id);
            OpenDataBase();
            SqlDataReader dataReader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            Product product;
            while (dataReader.Read())
            {
                product = new Product()
                {
                    Id = (int)dataReader["Id"],
                    Name = (string)dataReader["Ürün"],
                    Category = (string)dataReader["Kategori"],


                };
                products.Add(product);
            }
            CloseDataBase();
            return products;

        }
    }
}
