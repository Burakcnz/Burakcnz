namespace Proje04_SayiBulmacaWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GameStartPoint gameStartPoint = new GameStartPoint();
            int target = gameStartPoint.RndNumber;
            Console.WriteLine(target);
            gameStartPoint.Start(target);
        }
    }
}
