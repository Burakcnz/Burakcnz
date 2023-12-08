namespace Proje08_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WhileIntro

            /*
             while(koşul)
            {
             koşul true olduğu müddetçe döngü içindeki komutlar
            }            
             */


            #endregion

            #region Sample1

            //int sayac = 0;
            //while (sayac < 500000)
            //{
            //    Console.WriteLine($"sa dünya {sayac}");
            //    sayac++;
            //}


            #endregion

            #region Sample2

            //string message = "";
            //while (message.ToLower() != "exit")
            //{
            //    Console.Write("Bir mesaj gir: ");
            //    message = Console.ReadLine();
            //}

            #endregion

            #region Sample3
            //bool status=true;
            //string message;
            //do
            //{
            //    Console.Write("mesaj gir: ");
            //    message = Console.ReadLine();
            //}
            //while (message.ToLower()!="exit");


            #endregion

            #region Sample4

            //string number;
            //int total = 0;
            //for (int i = 0; i < Int32.MaxValue; i++)
            //{
            //    Console.Write($"{i + 1}.Sayıyı giriniz: ");
            //    number =Console.ReadLine();
            //    if (number.ToLower() == "exit") break;
            //    total +=Int32.Parse(number);
            //}
            //Console.WriteLine($"Sonuç: {total}");



            #endregion

            #region Sample5AlternativeForSample4

            //string value = "";
            //int total = 0;
            //do 
            //{
            //    Console.Write("Sayıyı Gir: ");
            //    value = Console.ReadLine();
            //    if (value != "ok") total = total + Int32.Parse(value);                
            //    total=total+Int32.Parse(value);
            //} while (value.ToLower()!="ok");
            //Console.WriteLine(total);


            #endregion

            #region Sample6

            //Random random = new Random();
            //int rndNumber=random.Next(1,100);
            //Console.WriteLine(rndNumber);


            #endregion

            #region Sample7
            //Random rnd = new Random();
            //int number;
            //for (int i = 0; i < 100; i++)
            //{
            //    //number = rnd.Next();
            //    //number = rnd.Next(100);
            //    number = rnd.Next(100,300);
            //    Console.WriteLine(number);

            //}
            #endregion

            #region Sample8Game1

            int target = 1;
            Random random = new Random();
            int number;
            do
            {
                number = random.Next(1,11);
                Console.WriteLine(number);

            } while (number!=target);

            #endregion
        }
    }
}
