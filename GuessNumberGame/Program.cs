using GuessNumberGame;
using Microsoft.Extensions.Configuration;


class Program
{


    static void Main()
    {

        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration config = builder.Build();
        int minNumber, maxNumber;
        GetUpperBoundAndLLowerBoundNumber(config, out minNumber, out maxNumber);

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
            IComputerGuessNumberGame game = new ComputerGuessNumberGame(minNumber, maxNumber);
            game.PlayComputerGuessNumberGame();
        }
    }

    private static void GetUpperBoundAndLLowerBoundNumber(IConfiguration config, out int minNumber, out int maxNumber)
    {
        minNumber = 1;
        maxNumber = 100000;
        int lowerboundNumber;

        if (int.TryParse(config["guessgame:lowerbound"], out lowerboundNumber))
        {
            minNumber = lowerboundNumber;
        }

        int upperboundNumber;

        if (int.TryParse(config["guessgame:upperbound"], out upperboundNumber))
        {
            maxNumber = upperboundNumber;
        }
    }
}