namespace Proje05_TarihMethotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);
            //DateTime birtday = new DateTime(1975, 7, 16);
            //Console.WriteLine(birtday);
            //string date1 = "19.07.1975";
            //Console.WriteLine(date1);

            DateTime bugun = DateTime.Today;
            DateTime simdi = DateTime.Now;
            DateTime birthday = new DateTime(1975, 7, 16);
            //Console.WriteLine(simdi.ToLongDateString());
            //Console.WriteLine(simdi.ToLongTimeString());
            //Console.WriteLine(simdi.ToShortDateString());
            //Console.WriteLine(simdi.ToShortTimeString());

            TimeSpan span=bugun.Subtract(birthday);
            Console.WriteLine(span.TotalDays);
            Console.WriteLine(span.TotalHours);
           
        }
    }
}
