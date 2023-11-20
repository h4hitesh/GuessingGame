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
    }
}
