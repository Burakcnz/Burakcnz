namespace Proje07_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForIntro
            /*
        
             for (sayaç ; koşul; sayaç değer değişimi)
            {
                döngüde tekrarlanması istenen komutlar
            }

             */

            //for (int sayac = 0; sayac < 5; sayac++)
            //{
            //    Console.WriteLine("sa dünya");
            //}

            #endregion

            #region Sample2

            //for (int i = 0; i <= 1000000; i++)
            //{
            //    if (i != 0)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine($"{i}: 2 nin katı");
            //        }
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine($"{i}: 3 ün katı");
            //        }
            //        if (i % 4 == 0)
            //        {
            //            Console.WriteLine($"{i}: 4 ün katı");
            //        }
            //    }
            //}

            #endregion

            #region Sample3
            //int sayi;
            //int enb = 0;
            //int enk=Int32.MaxValue;
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.Write($"{i}.Sayı girin: ");
            //    sayi = Int32.Parse(Console.ReadLine());
            //    if (sayi > enb) { enb = sayi; }
            //    if (sayi < enk) { enk = sayi; }
            //}
            //Console.WriteLine($"En Büyük Sayı: {enb}");
            //Console.WriteLine($"En Küçük Sayı: {enk}");

            #endregion

            #region Sample4
            //int toplam = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"Toplam: {toplam} , Sayaç: {i}");
            //    toplam += i;
            //}
            //Console.WriteLine($"Toplam Sonuç: {toplam}");

            #endregion

            #region Sample5

            //1-10 tek sayılar toplam
            //int tekToplam=0;
            //int ciftToplam=0;
            //for (int i = 1; i < 10; i++) 
            //{
            //    if (i % 2 == 0) ciftToplam += i;

            //    else tekToplam += i;
            //}
            //Console.WriteLine($"Tek Toplam: {tekToplam}");
            //Console.WriteLine($"Çift Toplam: {ciftToplam}");

            #endregion


        }
    }
}
