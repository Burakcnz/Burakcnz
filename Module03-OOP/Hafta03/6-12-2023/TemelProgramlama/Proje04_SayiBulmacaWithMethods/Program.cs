namespace Proje04_SayiBulmacaWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string cevap;
            do
            {
                Console.Clear();
                GameStartPoint gameStartPoint = new GameStartPoint();
                int target = gameStartPoint.RndNumber;
                Console.WriteLine(target);
                gameStartPoint.Start(target);
                Console.Write("Yeniden Oynamak İstermisiniz(y/n): ");
                cevap = Console.ReadLine();

            } while (cevap == "y");





        }
    }
}
