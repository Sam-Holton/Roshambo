using System;

namespace Roshambo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var valid = new Validator();
            var roshamboApp = new RoshamboApp();

            Console.WriteLine($"Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.Write($"Please enter your name: ");
            string name = valid.NameValidator();

            int difficultyChoice = roshamboApp.DifficultySelection();

            int humanPSRChoice = -1;
            int aiPSRChoice = -1;

            switch (difficultyChoice)
            {
                case 1:
                    {
                        var aiPlayer = new Stoner();
                        aiPSRChoice = aiPlayer.GenerateRoshambo();
                        break;
                    }
                case 2:
                    {
                        var aiPlayer = new ChaosMaster();
                        aiPSRChoice = aiPlayer.GenerateRoshambo();
                        break;
                    }
                default: break;
            }
            
            static void calculateWinner(int aiPlayerResult)
            {

            }
        }

        
    }
}

