

namespace Proje02_Classes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 31;
            person.Gender = "E";
            person.FirstName = "Burak Can";
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Gender);
            Console.WriteLine(person.FirstName);

            


        }
    }
}
