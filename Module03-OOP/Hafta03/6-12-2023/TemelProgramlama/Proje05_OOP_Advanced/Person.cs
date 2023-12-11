namespace Proje05_OOP_Advanced
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Intro()
        {
            Console.WriteLine($"Merhaba {FirstName} {LastName}, Hoş Geldiniz.");
        }
    }
    
}
