using GuessNumberGame;

class Program
{
    static void Main()
    {

        int minNumber = 1;
        int maxNumber = 100;


        Console.WriteLine("Choose a mode: [1]  Guess a number, [2] Computer guess a number");
        int mode;
        while (!int.TryParse(Console.ReadLine(), out mode) || (mode != 1 && mode != 2))
        {
            Console.WriteLine("Invalid input. Please enter 1 or 2.");
        }

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