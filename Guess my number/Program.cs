using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from 1 - 100");
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);

            int guess = -1;

            int count = 0;

            while (guess != rand)
            {
                count++;
                Console.Write("Guess: ");
                guess = int.Parse (Console.ReadLine());
                if(guess < rand)
                {
                    Console.WriteLine("Too looow!");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("Too hIgh!");
                }
                else
                {
                    Console.WriteLine($"WOWOWOW! correct. You tried {count} times.");
                    Console.ReadKey();
                }
            }
        }
    }
}
