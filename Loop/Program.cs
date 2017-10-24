using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            for (int x = 1; x <= number; x++)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("LuLu is disabled");
            Console.ReadLine();

            int num = 1;

            while(num <= 10)
            {
                Console.WriteLine(number);
                number++;
            }


            Console.ReadKey();
        }
    }
}