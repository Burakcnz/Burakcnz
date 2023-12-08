namespace Proje06_OOP_Advanced2.Repositories
{
    public class Employee : ProductRepository
    {
        public void Deneme()
        {
            ProductRepository pr = new ProductRepository();
            
        }
    }
    public class ProductRepository
    {
        /* Sanki veritabanından yada herhangi bir dış veri kaynağından veri çekiyormuşuz gibi işlem yapacağız.Yani bu durumu simule edecegiz */

        
        public List<Product> GetProduct(bool? isActive=null)
        {
            List<Product> products = new List<Product>
            {
                new Product{ID=1,Name="telefon1",Description="akıllı telefon",IsActive=true,CreatedDate=DateTime.Today },
                new Product{ID=2,Name="telefon2",Description="akıllı telefon",IsActive=true,CreatedDate=DateTime.Today },
                new Product{ID=3,Name="telefon3",Description="akıllı telefon",IsActive=true,CreatedDate=DateTime.Today },
                new Product{ID=4,Name="telefon4",Description="akıllı telefon",IsActive=false,CreatedDate=DateTime.Today },
                new Product{ID=5,Name="telefon5",Description="akıllı telefon",IsActive=true,CreatedDate=DateTime.Today },
                new Product{ID=6,Name="telefon6",Description="akıllı telefon",IsActive=false,CreatedDate=DateTime.Today },
            };
            List<Product> resultList = new List<Product>();
            if (isActive == null)
            {
                resultList=products;
            }
            else
            {
                foreach (var product in products)
                {
                    if (product.IsActive == isActive)
                    {
                        resultList.Add(product);
                    }
                }
            }

            return resultList;
        }
        public int PublicProperty
        {
            get;set;
        }
        protected int PrivateProperty
        {
            get;set;
        }
    }
}
