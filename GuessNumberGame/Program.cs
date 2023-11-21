using GuessNumberGame;

class Program
{
    static void Main()
    {

        int minNumber = 1;
        int maxNumber = 100;

        Console.WriteLine("Select a mode: [1] Guess a number, [2] Computer guess a number (type 'exit' to quit the game at any point)");

        Player player = new Player();
        int mode = player.GetValidResponseFromPlayer(1, 2);

        if (mode == 1)
        {
            Console.WriteLine($"Think of a number between. {minNumber} and {maxNumber}.");
            Console.WriteLine("Press [Enter] once you ready to play.");
            Console.ReadLine();

            IPlayerGuessNumberGame game = new PlayerGuessNumberGame(minNumber, maxNumber);
            game.PlayUserGuessNumberGame();
        }
        else
        {
            IComputerGuessNumberGame game = new ComputerGuessNumberGame(minNumber,maxNumber);
            game.PlayComputerGuessNumberGame();
        }
    }
}