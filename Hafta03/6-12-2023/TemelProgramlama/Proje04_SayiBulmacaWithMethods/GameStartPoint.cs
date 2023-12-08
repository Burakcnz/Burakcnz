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
            Game game = new Game();
            GameResult gameResult = new GameResult();
            bool cond;
            do
            {
                int guessNumber = userEntry.Guess(Count);
                gameResult = game.Play(guessNumber, target, Count, GuessCount);
                Count++;
                cond = !gameResult.IsGameOver && !gameResult.IsCountFull;
            } while (cond);

            if (gameResult.IsGameOver)
            {
                Console.WriteLine("Kazandınız!");
            }
            else if (gameResult.IsCountFull)
            {
                Console.WriteLine("Hakkınız Doldu Kaybettiniz");

            }





        }
    }
}
