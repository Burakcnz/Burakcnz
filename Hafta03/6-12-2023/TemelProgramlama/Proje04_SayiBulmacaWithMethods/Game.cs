namespace Proje04_SayiBulmacaWithMethods
{
    internal class Game
    {

        public GameResult Play(int guessNumber, int target, int count, int guessCount)
        {
            GameResult gameResult = new GameResult();
            if (guessNumber == target)
            {
                gameResult.IsGameOver = true;
            }

            if (count == guessCount)
            {
                gameResult.IsCountFull = true;                
            }
            return gameResult;
        }

    }
}
