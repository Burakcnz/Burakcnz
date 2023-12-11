namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("lütfen adını gir: ");
            //Console.ReadLine();
            //Console.WriteLine("bişi");
            //Console.WriteLine("ikişey");
            //Console.ReadLine();
            //ödev: console uygulamalında sonuç ekranın görünmesini sağlayan vs ayarını araştırınız.
            //int age;
            //age = 28;
            //Console.WriteLine(age);
            //byte point;
            //point = 255;
            //Console.WriteLine(point);
            //sbyte x;
            //x = -19;
            //Console.WriteLine(x);
            //int a;
            //a = point;
            //Console.WriteLine(a);
            //int sayi1;
            //sayi1 = 255;
            //Console.WriteLine(sayi1);
            //byte yeniSayi;
            //yeniSayi =Convert.ToByte(sayi1);
            //Console.WriteLine(yeniSayi);
            //string ad = "burak";
            //Console.WriteLine(ad);
            //byte age = 28;
            //string ad = "burak";
            //Console.Write(ad);
            //Console.Write(" ");
            //Console.WriteLine(age);
            //Console.WriteLine(age+" "+ad);
            //string firstName = "burak can";
            //string lastName = "zengin";
            //string city = "çorum";
            //byte age = 21;
            //char gender = 'E';

            ////yöntem 1
            //Console.WriteLine("Sayın " + firstName + " " + lastName + ", " + city + " şehrinde yaşayan " + age + " yaşında bir kişisiniz.Cinsiyetiniz : " + gender);

            ////yöntem 2
            //Console.WriteLine(String.Format("Sayın {0} {1}, {2} şehrinde yaşayan {3} yaşında bir kişisiniz.Cinsiyetiniz : {4}", firstName, lastName, city, age, gender));

            ////yöntem 3
            //Console.WriteLine($"Sayın {firstName} {lastName}, {city} şehrinde yaşayan {age} yaşında bir kişisiniz.Cinsiyetiniz : {gender}");

            //string result = $"Sayın {firstName} {lastName}, {city} şehrinde yaşayan {age} yaşında bir kişisiniz.Cinsiyetiniz : {gender}";
            //Console.WriteLine(result);

            int number1 = 40, number2 = 5, sum = number1 + number2;
            Console.WriteLine("Sonuç=" + sum);
            Console.WriteLine();//boş satır bırakır

            float ratio = 10.4f;
            decimal price = 50m;  //temsilen m yazılabiliri (opsiyonel)
            double x = 43.5d;     //temsilen d yazılabilir (opsiyonel)
            bool isActive = true; //true or false değerlerinden birini alabilir



        }
    }
}
