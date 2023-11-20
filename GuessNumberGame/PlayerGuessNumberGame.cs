namespace GuessNumberGame
{
    public class PlayerGuessNumberGame : IPlayerGuessNumberGame
    {
        private int minNumber;
        private int maxNumber;

        public PlayerGuessNumberGame(int lowerBound, int upperBound)
        {
            this.minNumber = lowerBound;
            this.maxNumber = upperBound;
        }
        public void PlayUserGuessNumberGame()
        {
            int computerGuess;
            int playerResponse = 0;
            Player player = new Player();
            do
            {
                computerGuess = (minNumber + maxNumber) / 2;
                Console.WriteLine($"Is your number {computerGuess}? [1] too low, [2] too high, [3] correct");

                playerResponse = player.GetValidResponseFromPlayer(1, 3);

                if (playerResponse == 1)
                {
                    minNumber = computerGuess + 1;
                }
                else if (playerResponse == 2)
                {
                    maxNumber = computerGuess - 1;
                }

            } while (playerResponse != 3);

            Console.WriteLine($"I guess your number: {computerGuess}");
        }
    }
}