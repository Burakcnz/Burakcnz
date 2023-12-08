namespace Proje04_SayiBulmacaWithMethods
{
    internal class UserEntry
    {
        public int Guess(int count)
        {
            Console.Write($"Lütfen {count}. tahmininizi giriniz(1-100): ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
