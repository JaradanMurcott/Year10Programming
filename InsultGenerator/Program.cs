using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string name = GetName();

            GenerateInsult(name, rnd);
        }

        private static string GetName()
        {
            Console.WriteLine("Present thy name and receive insult");
            return Console.ReadLine();
        }

        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine(name + ", you are " + GetAdjective(rnd) + " " + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }

        private static void Menu(string name, Random rnd)
        {
            Console.Write("Would you like another insult? y/n");
            if(Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
        }

        private static string GetObject(Random rnd)
        {
            string[] objects = {"homosexual" , "sociopath" , "retard" , "transgender" , "christian" , "dwarf" , "Sam Clark" , "Luke Wood"};
            return objects[rnd.Next(8)];
        }

        private static string GetCompoundAdjective(Random rnd)
        {
            string[] compoundAdjective = {"child-snatching" , "gender-changing" , "drug-running" , "peace-loving"};
            return compoundAdjective[rnd.Next(4)];
        }

        private static string GetAdjective(Random rnd)
        {
            string[] adjectives = { " a disabled", "a stunted", "an obese", "a filthy", "a creamy", "a vaping", "a midget", "a special" };
            return adjectives[rnd.Next(8)];
        }
    }
}
