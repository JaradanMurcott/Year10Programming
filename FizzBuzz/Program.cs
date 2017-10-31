using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10000000; i++) 
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Beep(700, 50);
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Fizz");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Beep(600, 50);

                }
                else if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Beep(500, 50);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
