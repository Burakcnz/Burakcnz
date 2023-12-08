using Proje06_OOP_Advanced2.Repositories;

namespace Proje06_OOP_Advanced2
{
    internal class Program
    {
        public static void DisplayProduct(List<Product> products, string StatusMessage="")
        {
            Console.WriteLine("--------------------------");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ID} - Name: {product.Name} - IsActive: {product.IsActive}");
            }
            Console.WriteLine($"Listelenen {StatusMessage} Ürün Sayısı: {products.Count}");
        }
        static void Main(string[] args)
        {
            #region Intro
            //Product p1 = new Product
            //{
            //    ID = 1,
            //    Name = "Kaçak Xiaomi Note 8 Pro",


            //};
            //Category c1 = new Category
            //{
            //    ID = 1,
            //    Name = "Telefon",
            //    ParentCategoryID = 0,
            //};

            #endregion

            #region AbstractClassProperty
            //Product p2 = new Product
            //{
            //    ID = 1,
            //    Name = "Test",
            //    Description = "Test",
            //};
            //Console.WriteLine(p2.Name);
            //Console.WriteLine(p2.CreatedDate);
            //Console.WriteLine(p2.IsActive);

            //Category c2 = new Category
            //{
            //    ID = 1,
            //    Name = "Category test",
            //};
            //Console.WriteLine("category IsActive: " + c2.IsActive);
            #endregion

            #region InterfaceAndGenerics

            //Product[] productsArray = new Product[5];
            //List<Product> productList = new List<Product>();
            //productList.Add(new Product
            //{
            //    ID = 1,
            //    Name = "Nokia 3310",
            //    IsActive = true
            //});
            //productList.Add(new Product
            //{
            //    ID = 2,
            //    Name = "general mobile",
            //    IsActive = false,
            //});
            ////Console.WriteLine(productList[0].Name);
            ////Console.WriteLine(productList[1].Name);

            //foreach (var products in productList)
            //{
            //    Console.WriteLine($"{products.ID} {products.Name} {products.IsActive}");
            //}
            #endregion

            #region ListSample1

            //Category c1 = new Category { ID = 1, Name = "Telefon" };
            //Category c2 = new Category { ID = 2, Name = "Bilgisayar" };
            //Category c3 = new Category { ID = 3, Name = "Konsol" };
            //Category c4 = new Category { ID = 4, Name = "Tablet" };
            //Category c5 = new Category { ID = 5, Name = "Müzik Ekipmanları" };
            //Category c6 = new Category { ID = 6, Name = "Oyun Ekipmanları" };

            ////c# da dizilerin eleman sayısını arttırma işlemi nasıl yapılır

            //List<Category> categoryList = new List<Category>() { c1, c2, c3, c4, c5 };
            //categoryList.Add(c6);
            //foreach (var category in categoryList)
            //    Console.WriteLine(category.ID + "-" + category.Name);

            #endregion

            #region Repository

            ProductRepository productRepository = new ProductRepository();

            string answer;
            do
            {
                
                Console.WriteLine("ANA MENÜ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1-Ürünleri Listele");
                Console.WriteLine("2-Aktif Ürünleri Listele");
                Console.WriteLine("3-Pasif Ürünleri Listele");
                Console.WriteLine("--------------------------");
                Console.WriteLine("0-Çıkış");
                Console.WriteLine();
                Console.Write("Lütfen Seçiminizi Giriniz: ");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    //tüm ürünleri listeyecek kodlar
                    List<Product> productList = productRepository.GetProduct(null);
                    DisplayProduct(productList);
                    Console.ReadLine();
                }
                else if (answer == "2")
                {
                    //aktif ürünler listeleyecek kodlar
                    List<Product> productsList = productRepository.GetProduct(true);
                    DisplayProduct(productsList,"Aktif");
                    Console.ReadLine() ;
                }
                else if (answer == "3")
                {
                    //pasif ürünler listeleyecek kodlar
                    List<Product> productsList=productRepository.GetProduct(false);
                    DisplayProduct(productsList,"Pasif");
                    Console.ReadLine() ;
                }
                Console.Clear();

            } while (answer != "0");

            #endregion

        }
    }
}
