using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame.Test
{
    public class PlayerTest
    {
        [Test]
        public void CheckPlayerGuess_tooLow()
        {
            // Arrange
            string expectedOutput = "too low";
            int secretNumber = 10;
            int playerGuess = 5;
            //act
            Player player = new Player();
            string actualOutput = player.CheckPlayerGuess(secretNumber, playerGuess);
            //Assert
            Assert.AreEqual(expectedOutput.ToLower(), actualOutput.ToLower());
        }
        [Test]
        public void CheckPlayerGuess_tooHigh()
        {
            // Arrange
            string expectedOutput = "too high";
            int secretNumber = 10;
            int playerGuess = 45;
            //act
            Player player = new Player();
            string actualOutput = player.CheckPlayerGuess(secretNumber, playerGuess);
            //Assert
            Assert.AreEqual(expectedOutput.ToLower(), actualOutput.ToLower());
        }

        [Test]
        public void CheckPlayerGuess_correct()
        {
            // Arrange
            string expectedOutput = "correct";
            int secretNumber = 35;
            int playerGuess = 35;
            //act
            Player player = new Player();
            string actualOutput = player.CheckPlayerGuess(secretNumber, playerGuess);
            //Assert
            Assert.AreEqual(expectedOutput.ToLower(), actualOutput.ToLower());
        }

        [Test]
        [TestCase(10, 50, 23, ExpectedResult = true)]
        [TestCase(1, 50, 1, ExpectedResult = true)]
        [TestCase(1, 3, 3, ExpectedResult = true)]
        [TestCase(1, 50, 51, ExpectedResult = false)]

        public bool IsNumberInRange_valid_Test(int minNumber, int maxNumber, int inputNumber)
        {
            Player player = new Player();
            bool isValid = player.IsNumberInRange(minNumber, maxNumber, inputNumber);

            return isValid;
        }
    }
}
