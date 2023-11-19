using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Player
    {
        public string CheckPlayerGuess(int secretNumber, int playerGuess)
        {
            if (playerGuess < secretNumber)
            {
                return "Too low";
            }
            else if (playerGuess > secretNumber)
            {
                return "Too high";
            }
            else
            {
                return "Correct";
            }
        }

        public int GetValidResponseFromPlayer(int min, int max)
        {
            int playerResponse;
            bool IsValidNumber = false;
            do
            {
                int.TryParse(Console.ReadLine(), out playerResponse);

                IsValidNumber = IsNumberInRange(min, max, playerResponse);
                if (!IsValidNumber)
                {
                    Console.WriteLine("Invalid input.");
                }

            } while (!IsValidNumber);


            return playerResponse;
        }
        public  bool IsNumberInRange(int min, int max, int inputNumber)
        {
            bool IsValidNumber;
            if (inputNumber < min || inputNumber > max)
            {

                IsValidNumber = false;
            }
            else
            {
                IsValidNumber = true;
            }

            return IsValidNumber;
        }
    }
}
