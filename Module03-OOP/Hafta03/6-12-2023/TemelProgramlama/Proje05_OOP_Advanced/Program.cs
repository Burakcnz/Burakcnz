namespace Proje05_OOP_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ınheritance
            Araba araba1 = new Araba();
            araba1.Marka = "Mercedes";
            araba1.Model = "CLK 500";
            araba1.kapiSayisi = 4;
            araba1.ModelYili = 2013;
            araba1.Fiyat = 145870;

            ElektirikliAraba araba2 = new ElektirikliAraba();
            araba2.GucTuketimi = 5;
            araba2.Marka = "Tesla";
            #endregion




            #region Person
            //Person person = new Person();
            //person.FirstName = "Burak Can";
            //person.LastName = "Zengin";
            //person.Intro();

            Writer 

            #endregion

        }

    }
}
