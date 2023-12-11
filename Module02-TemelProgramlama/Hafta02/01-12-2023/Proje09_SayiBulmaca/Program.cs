namespace Proje09_SayiBulmaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            string cevap = "";
            do
            {
                Console.Clear();
                int uretilenSayi = rastgele.Next(1, 101);
                int tahminEdilenSayi;
                string mesaj = "";
                int hak = 5;
                int puan = 100;

                do
                {
                    Console.WriteLine($"Hile: {uretilenSayi}");
                    Console.Write($"Tahmininizi giriniz (Hak: {hak}): ");
                    tahminEdilenSayi = Int32.Parse(Console.ReadLine());
                    hak--;

                    if (tahminEdilenSayi > uretilenSayi)
                    {
                        mesaj = ("Daha Küçük Bir Sayı Gir!");
                    }

                    else if (tahminEdilenSayi < uretilenSayi)
                    {
                        mesaj = ("Daha Büyük Bir Sayı Gir!");
                    }

                    if (tahminEdilenSayi != uretilenSayi)
                    {
                        puan -= 20;
                        Console.WriteLine(mesaj);
                    }

                } while (tahminEdilenSayi != uretilenSayi && hak > 0);
                mesaj = tahminEdilenSayi == uretilenSayi ? "Tebrikler Kazandınız" : "Kaybettiniz";
                Console.WriteLine($"{mesaj} Puanınız: {puan}");
                Console.WriteLine("");
                do
                {
                    Console.Write("Yeniden Oynamak İstiyormusunuz(y/n): ");
                    cevap = Console.ReadLine();
                } while (cevap.ToLower() != "y" && cevap.ToLower() != "n");

            } while (cevap.ToLower() == "y");
        }
    }
}
