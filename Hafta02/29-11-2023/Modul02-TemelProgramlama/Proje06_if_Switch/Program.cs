namespace Proje07_if_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ZamanCizelgesi
            /*
                 10:00 - 11:30 : 1.Blok(2 ders)
                 11:30 - 11:45 : Teneffüs
                 11:45 - 12:30 : 2.Ders
                 12:30 - 13:00 : Teneffüs
                 13:00 - 14:30 : 3. Blok(2 ders)
            */
            #endregion

            #region IfIntro
            /*
                if(logical)
                {
                    logical true ise yapılacak işlemler
                }


                if(logical)
                {
                    logical true ise yapılacak işlemler
                } 
                else
                {
                    logical false ise yapılacak işlemler
                }

                if(logical1)
                {
                    logical1 true ise yapılacak işlemler
                } 
                else if(logical2)
                {
                    logical2 true ise yapılacak işlemler
                }
                else if(logical3)
                {
                    logical3 true ise yapılacak işlemler
                }
                else
                {
                    logical3 false ise yapılacak işlemler
                }
             */
            #endregion

            #region Sample1
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //int age = Int32.Parse(Console.ReadLine());
            //if (age >= 18)
            //{

            //    Console.WriteLine("Reşitsiniz!");
            //}
            #endregion

            #region Sample2
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age<18)
            //{
            //    Console.WriteLine("Giremezsiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Girebilirsiniz!");
            //}
            #endregion

            #region Sample3
            //Console.Write("1.Sayı: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());
            //Console.Write("2.Sayı: ");
            //int sayi2 = Int32.Parse(Console.ReadLine()); 
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"{sayi1} büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi2} büyüktür.");
            //}
            #endregion

            #region Sample4
            //Console.Write("1.Sayı: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());
            //Console.Write("2.Sayı: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"{sayi1} büyüktür.");
            //    //Sayı 1 (54), Sayı 2 (44)'den büyüktür.
            //}
            //else if(sayi2>sayi1)
            //{
            //    Console.WriteLine($"{sayi2} büyüktür.");
            //    //Sayı 2 (54), Sayı 1 (44)'den büyüktür.
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi1} ve {sayi2} birbirine eşittir.");
            //    //Sayı 1 (50) ve Sayı 2(50) birbirine eşittir.
            //}
            #endregion

            #region Sample5


            //int enb = 0;

            //Console.Write("1.Sayı: ");
            //int sayi1 = Int32.Parse(Console.ReadLine());

            //Console.Write("2.Sayı: ");
            //int sayi2 = Int32.Parse(Console.ReadLine());

            //Console.Write("3.Sayı: ");
            //int sayi3 = Int32.Parse(Console.ReadLine());

            ////if (sayi1>=enb)
            ////{
            ////    enb = sayi1;   
            ////}
            ////if(sayi2>=enb)
            ////{
            ////    enb = sayi2;
            ////}
            ////if (sayi3>=enb)
            ////{
            ////    enb = sayi3;
            ////}

            //if (sayi1 >= enb) enb =sayi1;
            //if (sayi2 >= enb) enb =sayi2;
            //if (sayi3 >= enb) enb = sayi3;

            //Console.Clear();

            //Console.Write($"1.S: {sayi1} - ");
            //Console.Write($"2.S: {sayi2} - ");
            //Console.WriteLine($"3.S: {sayi3}");
            //Console.WriteLine($"En Büyük: {enb}");
            #endregion

            #region TernaryIf1
            //int age = 14;
            //string message = age >= 18 ? "Reşit" : "Reşit değil";
            //Console.WriteLine(message);
            #endregion

            #region TernaryIf2
            //Console.Write("Yaşınızı giriniz: ");
            //int age = Int32.Parse(Console.ReadLine());
            //string message = age < 20 ? "Genç!" : "Yaşlı";
            //Console.WriteLine(message);
            #endregion

            #region TernaryIf3
            /*
             * 0-15: Çocuk
             * 16-35: Genç
             * 36-50: Orta yaşlı
             * 51-80: Yaşlı
             * 81 ve daha büyük: Ölmüşsün ağlayanın yok:)
             */
            //Console.Write("Yaşınızı giriniz: ");
            //int age = Int32.Parse(Console.ReadLine());
            //string result = age <= 15 ? "Çocuk" :
            //                  age <= 35 ? "Genç" :
            //                    age <= 50 ? "Orta yaşlı" :
            //                        age <= 80 ? "Yaşlı" : "Ölmüşsün, ağlayanın yok";
            //Console.WriteLine(result);
            #endregion

            #region Sample6
            //string result="";
            //Console.Write("Yaşınızı giriniz: ");
            //int age = Int32.Parse(Console.ReadLine());
            //if (age<=15)
            //{
            //    result = "Çocuk";
            //}
            //if(age>15 && age<=35)
            //{
            //    result = "Genç";
            //}
            //if(age>35 && age<=50)
            //{
            //    result = "Orta yaşlı";
            //}
            //if (age>50 && age <= 80)
            //{
            //    result = "Yaşlı";
            //}
            //if(age>80)
            //{
            //    result = "Ölmüşsün, ağlayanın yok.";
            //}
            //// Ya da operatörü ||
            //Console.WriteLine(result);
            #endregion

            #region SwitchIntro
            /*
             * switch (var)
             * {
             *      case value1: 
             *          işlemler;
             *          break;
             *      case value2:
             *          işlemler;
             *          break;
             *      case value3:
             *          işlemler;
             *          break;
             *      case ...
             *      default:
             *          işlemler;
             *          break;
             * }
             */
            #endregion

            #region SwitchSample1

            //char gender = 'B';
            //switch (gender)
            //{
            //    case 'K':
            //        Console.WriteLine("Kadın");
            //        break;

            //    case 'E':
            //        Console.WriteLine("Erkek");
            //        break;
            //    default: Console.WriteLine("Lütfen K veya E yazın");
            //        break;

            //}

            #endregion

            #region SwitchSample2

            //Console.WriteLine("Lütfen yaş giriniz: ");
            //int age = Int32.Parse(Console.ReadLine());
            //string resultMessage = "";
            //switch (age)
            //{
            //    case < 0:
            //        resultMessage = "LÜtfen 0 dan büyük sayı giriniz!";
            //        break;

            //    case <= 15:
            //        resultMessage = "Çocuk";
            //        break;

            //    case <= 35:
            //        resultMessage = "Genç";
            //        break;

            //    case <= 50:
            //        resultMessage = "Orta Yaşlı";
            //        break;

            //    case <= 80:
            //        resultMessage = "Yaşlı";
            //        break;

            //    default:
            //        resultMessage = "ölmüşsün ağlayanın yok";
            //        break;
            //}
            //Console.WriteLine(resultMessage);

            #endregion

            #region SwitchSample3
            //DateTime today = DateTime.Today;
            //DateTime today = new DateTime(2023, 11, 29);
            //DayOfWeek dayOfWeek = today.DayOfWeek;
            //Console.WriteLine(dayOfWeek);

            ////if ile
            //if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            //{
            //    Console.WriteLine("Hafta Sonu");
            //}
            //else { Console.WriteLine("Hafta İçi"); }


            //switch (dayOfWeek)
            //{

            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("hafta sonu");
            //        break;
            //    default:
            //        Console.WriteLine("hafta içi");
            //        break;
            //}


            #endregion

            #region SwitchSample4

            //0-99 arası %10 , 100-199 arası %20 , 200 ve üzeri %30 indirim
            Console.Write("Ürünün Fiyatını Giriniz: ");
            double price = Convert.ToDouble(Console.ReadLine());
            double ratio = 0;
            switch (price)
            {
                case (> 0 and < 100):
                    ratio = 0.1; break;
                case (>= 100 and < 200):
                    ratio = 0.2; break;
                default:
                    ratio = 0.3; break;              
                     
            }
            Console.WriteLine("Sonuç");
            double discount=price*ratio;
            double discountPrice=price-discount;
            Console.WriteLine($"Ürün Fiyatı {price}₺ ");
            Console.WriteLine($"İndirim Oranı {ratio}");
            Console.WriteLine($"İndirimli Fiyat {discountPrice}₺");

            #endregion


        }
    }
}
