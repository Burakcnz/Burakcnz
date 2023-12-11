namespace Proje01_OOP_Intro
{
    internal class Program
    {

        class Product
        {
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }
            public string ProductDescription { get; set; }
        }

        static void Main(string[] args)
        {
            //int number1 = 45;
            //Console.WriteLine(number1);

            Product p1 = new Product();
            Product p2 = new Product();
            p1.ProductName = "Kaçak Xiaomi";
            p1.ProductPrice = 8500;
            p1.ProductDescription = "Kaçak Telefon";
            Console.WriteLine($"Product 1 Name: {p1.ProductName}");
            Console.WriteLine($"Product 1 Price: {p1.ProductPrice}");
            Console.WriteLine($"Product 1 Description: {p1.ProductDescription}");
        }
    }
}
