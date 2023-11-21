using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Test
{
    public class ComputerGuessNumberTest
    {
        [Test]
        public void GenerateRandomNumber_ReturnsNumberWithinRange()
        {
            // Arrange
            int minNumber = 1;
            int maxNumber = 100;

            // Act
            IComputerGuessNumberGame computerGuessNumberGame = new ComputerGuessNumberGame(minNumber, maxNumber);
            int randomNumber = computerGuessNumberGame.GenerateRandomNumber();

            // Assert
            Assert.GreaterOrEqual(randomNumber, minNumber, "Generated number should be greater than or equal to minNumber");
            Assert.LessOrEqual(randomNumber, maxNumber, "Generated number should be less than or equal to maxNumber");
        }


        [Test]
        public void ComputerGuess_Test()
        {
            // Arrange
            int computerSecret = 37;
          
            using (var consoleOutput = new StringWriter())
            {
               
                Console.SetOut(consoleOutput);
                var playerInput = String.Join(Environment.NewLine, new[]
                {
                    "50",
                    "25",
                    "37"
                });

                Console.SetIn(new System.IO.StringReader(playerInput));


                // usage:

                // Act
                IComputerGuessNumberGame game = new ComputerGuessNumberGame(1, 100);
                bool isFound = game.GuessComputerSecretNumber(computerSecret);
               
                // Assert
                
                Assert.IsTrue(isFound); 
            }
        }

    }
}
