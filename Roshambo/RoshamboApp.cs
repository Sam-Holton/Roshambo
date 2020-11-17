using System;

namespace Roshambo
{    
    class RoshamboApp
    {
        public int DifficultySelection()
        {
            var valid = new Validator();

            Console.Clear();
            Console.WriteLine($"1: Stoner (easy)");
            Console.WriteLine($"2: Chaosmaster (difficult)");
            Console.WriteLine($"Who would you like to play against? ");

            var difficultySelection = valid.DifficultyValidator();
            return difficultySelection;
        }
    }    
}

