namespace Exercies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CarpımTablosu
            /*çarpım tablosunu aşağıdaki şekilde ekrana yazdıran kodları yazın
             * 1x1=1
             * 1x2=2
             * 6x1=6*/

            //int number1 = 1;
            //int number2 = 1;

            //do
            //{
            //    number2 = 1;
            //    do
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Console.WriteLine($"{number1} x {number2}= {number1 * number2}");
            //            number2++;                        
            //        }
            //    } while (number2 < 9);
            //    Console.WriteLine("");
            //    number1++;
            //} while (number1! < 11);

            //odev : bu çalışmayı for kullanarak yapın!

            #endregion

            #region MyRegion
            //aşağıdaki çıktıyı veren kodu yazın
            /*
            1
            12
            123
            1234
            12345
            12345
            1234
            123
            12
            1
             */

            int k;
            int l;

            l = 1;
            do
            {
                k = 1;
                do
                {
                    Console.Write($"{k}");
                    k++;
                } while (k <= l);
                l++;
                Console.WriteLine("");
            } while (l <= 5);


            #endregion
        }
    }
}
