using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to my program " + name );


            // Wait at the end
            Console.ReadKey();
        }
    }
}