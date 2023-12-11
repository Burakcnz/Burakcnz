namespace Proje04_SayiBulmacaWithMethods
{
    internal class GameStartPoint
    {
        public int RndNumber { get; set; }
        public int GuessCount { get; set; }
        public int Count { get; set; }

        public GameStartPoint()
        {
            //bu methoda constructor method denir
            //buraya yazılan kodlar bu sınıftan nesne üretildiği anda(new) çalışır

            RndNumber = Rnd.GetNumber();
            GuessCount = 5;
            Count = 1;

        }

        public void Start(int target)
        { 
            UserEntry userEntry = new UserEntry();
            do
            {
                int guessNUmber = userEntry.Guess(Count);
                if (guessNUmber==target)
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                Count++;
            } while (true);
        }
    }
}
