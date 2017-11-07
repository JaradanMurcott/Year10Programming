using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            string[] answers = { "Maybe", "It is so", "Nein", "Ja", "Ask again", "Most definitly not", "kys" };

            Console.WriteLine("QnA with Tony Jones. Type 'Exit' to leave");

            if (Console.ReadLine() != "Exit")
            {
                Random rnd = new Random();
                Console.WriteLine(answers[rnd.Next(7)]);

                playGame();
            }

        }
    }
}
