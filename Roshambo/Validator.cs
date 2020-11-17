using System;
using System.Text.RegularExpressions;

namespace Roshambo
{
    public class Validator
    {
        public int DifficultyValidator()
        {
            do
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result) && result >= 1 && result <= 2)
                {
                    return result;
                }
                else
                {
                    Console.Write($"Please enter a valid input: ");
                }
            } while (true);
        }
        public int GenerateRoshamboValidator()
        {
            do
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result) && result >= 1 && result <= 3)
                {
                    return result;
                }
                else
                {
                    Console.Write($"Please enter a valid input: ");
                }
            } while (true);
        }

        public string NameValidator()
        {
            var rx = new Regex(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$");
            // Matches single first name string or first and last name string with one space. 
            // Good for instant searches that trigger after keyup events.
            // by Andre Dublin

            do
            {
                string userInput = Console.ReadLine();
                if (rx.IsMatch(userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.Write($"Please enter a valid name: ");
                }
            } while (true);
        }
    }
}

