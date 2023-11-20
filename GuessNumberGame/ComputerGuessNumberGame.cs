namespace GuessNumberGame
{
    public class ComputerGuessNumberGame : IComputerGuessNumberGame
    {
        private int minNumber;
        private int maxNumber;
        public ComputerGuessNumberGame(int lowerBound, int upperBound)
        {
            this.minNumber = lowerBound;
            this.maxNumber = upperBound;
        }
        public void PlayComputerGuessNumberGame()
        {
            int secretNumber = GenerateRandomNumber();
            int playerGuess;
            Player player = new Player();
            do
            {
                Console.WriteLine($"Enter your guess between {minNumber} and {maxNumber}: ");

                playerGuess = player.GetValidResponseFromPlayer(minNumber, maxNumber);

                string result = player.CheckPlayerGuess(secretNumber, playerGuess);

                Console.WriteLine(result);

            } while (playerGuess != secretNumber);

            Console.WriteLine("Welldone , You guessed my number.");
        }

        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber + 1);
        }
    }
}
