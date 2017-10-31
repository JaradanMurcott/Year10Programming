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
            
        }

        private static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if(computerChoice == "Rock")
                {
                    return "Draw";
                }
                else if(computerChoice == "Paper")
                {
                    return "Lose";
                }
                else if(computerChoice == "Scissors")
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
                else if (computerChoice == "Scissors")
                {
                    return "Lose";
                }
            }
            else if (userChoice == "Scissors")
            {
                if (computerChoice == "Rock")
                {
                    return "Lose";
                }
                else if (computerChoice == "Paper")
                {
                    return "Win";
                }
                else if (computerChoice == "Scissors")
                {
                    return "Draw";
                }
            }    
        }

        private static string ComputerTurn()
        {
            
        }

        private static string UserTurn()
        {
            
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.WriteLine("User Score: 100\t\tComputer Score: 100");
        }
    }
}
