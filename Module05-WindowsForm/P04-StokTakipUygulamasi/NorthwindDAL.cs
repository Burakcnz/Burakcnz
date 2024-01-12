using P03_SqlWithNorthwind.Entities;
using P03_SqlWithNorthwind.Models;
using System.Data;
using System.Data.SqlClient;

namespace P03_SqlWithNorthwind
{
    internal static class NorthwindDAL
    {
        static SqlConnection connection=CreateConnection();


        private static SqlConnection CreateConnection()
        {
            string serverName = "DESKTOP-3O41JPC";
            string dbName = "Northwind";
            string connectionString = $"Server={serverName};Database={dbName};Trusted_Connection=true;TrustServerCertificate=true";
            return new SqlConnection(connectionString);


        }
        private static void OpenDataBase()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
        }
        private static void CloseDataBase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static DataTable GetAllProducts()
        {
            string queryString = @"
            SELECT
	           p.ProductID AS [ID],
               p.ProductName AS [Ürün],
               c.CategoryName AS [Kategori],
               p.UnitPrice AS [Fiyat],
               p.UnitsInStock AS [Stok],
               c.CategoryID AS [CategoryID]
             FROM Products p 
	          JOIN Categories c 
		       ON p.CategoryID=c.CategoryID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, connection);
            DataTable dataTable = new DataTable();
            OpenDataBase();
            sqlDataAdapter.Fill(dataTable);
            CloseDataBase();//aslında sql dataadapter sınıfından yaratılan nesnemiz oto olarak bağlantıyı kapatır.biz burada sadece mantığını anlayalım diye yazdık.
            return dataTable;
        }
        public static LinkedList<Category> GetAllCategories()
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
            LinkedList<Category> categories = new();
            Category category;

            while (dataReader.Read() == true)
            {
                category = new Category()
                {
                    //Id = Convert.ToInt32(dataReader["CategoryID"])
                    Id = (int)dataReader["CategoryID"],
                    Name = dataReader["CategoryName"].ToString(),
                    Description = (string)dataReader["Description"]
                    //Description = (string)dataReader["Description"]
                };
                categories.AddLast(category);
            }
            CloseDataBase();
            return categories;

        }

        public static List<Product> GetAllProductsByCategoryId(int id)
        {
            string queryString = @$"
                SELECT
	                p.ProductID AS [ID],
	                p.ProductName AS [Ürün],
	                c.CategoryName AS [Kategori],
	                p.UnitPrice AS [Fiyat],
	                p.UnitsInStock AS [Stok],
                    c.CategoryID AS [CategoryID]
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
                    Price = (decimal)dataReader["Fiyat"],
                    Stock = (Int16)dataReader["Stok"],
                    CategoryId = (Int32)dataReader["CategoryID"],

                };
                products.Add(product);
            }
            CloseDataBase();
            return products;

        }
        public static void CreateProduct(AddProductModel model)
        {
            model.Price = Convert.ToInt32(model.Price);
            string quryString = $@"
                INSERT INTO Products 
                	(ProductName,CategoryID,UnitPrice,UnitsInStock) 
                VALUES 
                	('{model.Name}',{model.CategoryID},{model.Price},{model.Stock})";
            OpenDataBase();
            SqlCommand cmd = new SqlCommand(quryString, connection);
            cmd.ExecuteNonQuery();
            CloseDataBase();
        }

        public static void UpdateProduct(Product model)
        {
            model.Price = Convert.ToInt32(model.Price);
            string quryString = $@"
                UPDATE Products SET 
	                ProductName='{model.Name}',
	                UnitPrice={model.Price},
	                UnitsInStock={model.Stock},
	                CategoryID={model.CategoryId}
                WHERE ProductID={model.Id}";
            OpenDataBase();
            SqlCommand cmd = new SqlCommand(quryString, connection);
            cmd.ExecuteNonQuery();
            CloseDataBase();
        }
        public static void DeleteProduct(int id)
        {           
            string quryString = $@"
                DELETE Products 	          
                WHERE ProductID={id}";
            OpenDataBase();
            SqlCommand cmd = new SqlCommand(quryString, connection);
            cmd.ExecuteNonQuery();
            CloseDataBase();
        }
    }
}
