using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "mans not hot";
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while(repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);
                string userChoice = UserTurn();
                string computerChoice = ComputerTurn();
                result = DetermineWinner(userChoice,computerChoice);
                GiveFeedback(result, userChoice, computerChoice);
                updateScores(result, ref userScore, ref computerScore);
                repeat = PlayAgain();
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again? y/n");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void updateScores(string result, ref int userScore, ref int computerScore)
        {
            if(result == "Win")
            {
                userScore++;
            }
            else if(result == "Lose")
            {
                computerScore++;
            }

        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine($"{result}! You chose {userChoice} and the computer chose {computerChoice}!");
        }

        private static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if (computerChoice == "Rock")
                {
                    return "Draw";
                }
                else if (computerChoice == "Paper")
                {
                    return "Lose";
                }
                else 
                {
                    return "Win";
                }
            }
            else if (userChoice == "Paper")
            {
                if (computerChoice == "Rock")
                {
                    return "Win";
                }
                else if (computerChoice == "Paper")
                {
                    return "Draw";
                }
                else 
                {
                    return "Lose";
                }
            }
            else 
            {
                if (computerChoice == "Rock")
                {
                    return "Lose";
                }
                else if (computerChoice == "Paper")
                {
                    return "Win";
                }
                else 
                {
                    return "Draw";
                }
            }    
        }

        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1,4);
            if(choice == 1)
            {
                return "Rock";
            }          
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private static string UserTurn()
        {
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.WriteLine("User Score: 100\t\tComputer Score: 100");
        }
    }
}
