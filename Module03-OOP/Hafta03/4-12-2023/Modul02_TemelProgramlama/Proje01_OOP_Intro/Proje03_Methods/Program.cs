namespace Proje03_Methods
{
    internal class Program
    {



        static int Topla(int s1, int s2, int s3, int s4)
        {
            return s1 + s2 + s3 + s4;
        }
        static int Topla(int s1, int s2, int s3)
        {
            return s1 + s2 + s3;
        }
        static int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static void Main(string[] args)
        {
            #region MethodsIntro
            //for (int i = 0; i < 5; i++)
            //{
            //    Hello();
            //}
            #endregion
            #region Sample1
            //Topla();
            //Topla2(100, 78);
            //int sonuc = Topla3(100, 200);
            //Console.WriteLine(sonuc /2);
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Rastgele Sayı: {Rast()}");
            //}
            #endregion
            #region OverLoading
            Console.WriteLine(Topla(75, 75, 100, 700));
            Console.WriteLine(Topla(75, 75, 100));
            Console.WriteLine(Topla(75, 75));
            #endregion
        }
    }
}
