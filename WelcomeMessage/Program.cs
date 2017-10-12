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
            Console.Write("Enter Your Age: ");
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine("Welcome to my program " + name + ", your recorded age is " + age);


            // Wait at the end
            Console.ReadKey();
        }
    }
}