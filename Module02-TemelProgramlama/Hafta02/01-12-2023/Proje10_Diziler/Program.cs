namespace Proje10_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArraysIntro
            //int[] yaslar = new int[3];
            //yaslar[0] = 123;
            //yaslar[1] = 456;
            //yaslar[2] = 789;
            //Console.WriteLine(yaslar[0]);
            //Console.WriteLine(yaslar[1]);
            //Console.WriteLine(yaslar[2]);
            #endregion

            #region Sample1

            int[] yaslar = new int[3] { 19, 34, 25 };
            int[] yaslar2 = { 1, 5, 9, 23, 456, 7513845, 1235, 987 };
            string[] studentsNames = { "Ali", "Veli", "Burak", "Mahmut" };
            //Console.WriteLine(studentsNames[0]);
            //Console.WriteLine(yaslar2);
            //Console.WriteLine($"dizi eleman sayısı: {studentsNames.Length}");            
            //for (int i = 0; i < studentsNames.Length; i++)
            //{
            //    Console.WriteLine(studentsNames[i]);
            //}

            //foreach (var item in studentsNames)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Sample2
            //double[] maaslar = { 40, 50, 35, 25, 33 };

            //for (int i = 0; i < maaslar.Length; i++)
            //{
            //    Console.WriteLine($"zamsız {maaslar[i]}");

            //    maaslar[i] = maaslar[i] * 1.1;
            //    Console.WriteLine($"zamlı {maaslar[i]}");
            //}

            //double[] zamliMaaslar = new double[5];
            //int index = 0;
            //foreach (double maas in maaslar)
            //{
            //    Console.WriteLine($"zamsız maaş {maas}");
            //    zamliMaaslar[index] = maas*1.1;
            //    Console.WriteLine($"zamlı maaş {zamliMaaslar[index]}");
            //    Console.WriteLine("");
            //    index++;
            //}
            #endregion

            #region Sample3

            /*içerisine 1-100 arasındaki dsayılardan rastgele sayılar atanacak 10 elemanlı bir int dizisi tanımlayıp bu dizideki sayıların toplamını bulup konsola yazdıralım
             10 adet elemanı olan dizi oluşturuluyor*/

            //int[] numbers = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 6);
            //    //Console.WriteLine(numbers[i]);
            //}

            ////toplam bulunuyor
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}


            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine( "toplam değeri: "+total);
            #endregion

            #region Sample4
            /*kullanıcının ad soyad girmesini sağla
             girilen ad soyadın aşağıdaki gibi yazılmasını sağlayın
            b
            u
            r
            a
            k
            
            c
            a
            n
             
            z
            e
            n
            g
            i
            n
            */

            //Console.Write("Ad soyad giriniz: ");
            //string fulName=Console.ReadLine();
            //foreach (char karakter in fulName.ToUpper())
            //{
            //    Console.WriteLine(karakter);
            //}

            #endregion

            #region Sample5
            //4 ün değişik hali

            //Console.Write("Ad soyad giriniz: ");
            //string fulName = Console.ReadLine();
            //foreach (char karakter in fulName.ToUpper().Reverse())
            //{
            //    Console.WriteLine(karakter);
            //}

            #endregion

        }
    }
}
