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

            bool numberfound = GuessComputerSecretNumber(secretNumber);
            if (numberfound)
            {
                Console.WriteLine("Welldone , You guessed my number.");
            }

        }

        public bool GuessComputerSecretNumber(int secretNumber)
        {
            bool numberFound = false;

            int playerGuess;
            Player player = new Player();
            do
            {
                Console.WriteLine($"Enter your guess between {minNumber} and {maxNumber}: ");

                playerGuess = player.GetValidResponseFromPlayer(minNumber, maxNumber);

                string result = player.CheckPlayerGuess(secretNumber, playerGuess);

                Console.WriteLine(result);

                if (playerGuess == secretNumber)
                {
                    numberFound = true;
                    break;
                }


            } while (playerGuess != secretNumber);

            return numberFound;

        }

        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber + 1);
        }
    }
}
