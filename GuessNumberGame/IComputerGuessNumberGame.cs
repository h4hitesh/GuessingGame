namespace GuessNumberGame
{
    public interface IComputerGuessNumberGame
    {
        void PlayComputerGuessNumberGame();
        bool GuessComputerSecretNumber(int secrectNumber);
        int GenerateRandomNumber();
    }
}
