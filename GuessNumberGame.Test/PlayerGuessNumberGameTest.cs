namespace GuessNumberGame.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayGame_CorrectGuess_ReturnsCongratulations()
        {
            // Arrange
            string playerGuessNumber = "80";
            using (var consoleInput = new StringReader(playerGuessNumber))
            using (var consoleOutput = new StringWriter())
            {
                Console.SetIn(consoleInput);
                Console.SetOut(consoleOutput);

                var playerInput= String.Join(Environment.NewLine, new[]
                {
                    "1",
                    "1",
                    "2",
                    "2",
                    "1",
                    "1",
                    "3"
                });

                Console.SetIn(new System.IO.StringReader(playerInput));

                // usage:

                // Act
                IPlayerGuessNumberGame game = new PlayerGuessNumberGame(1, 100);
                game.PlayUserGuessNumberGame();

                // Assert
                string result = consoleOutput.ToString();
                StringAssert.Contains($"I guess your number: {playerGuessNumber}", result);
            }
        }

        //[Test]
        //public void CheckGuess_CorrectGuess_ReturnsCorrect()
        //{
        //    // Arrange
        //    GuessGame game = new GuessGame(1, 100);
        //    int playerGuessNumber = 42;

        //    // Act
        //    string result = game.PlayerGuessGame(playerGuessNumber, 42);

        //    // Assert
        //    Assert.AreEqual("Correct", result);
        //}
    }
}