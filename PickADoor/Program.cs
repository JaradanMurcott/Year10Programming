using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Nazi 1,2,3,4");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind door 1 is Heinrich Himmler");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind door 2 is Joseph Gobbels");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind door 3 is Herman Goring");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Behind door 4 is the Fuhrer himself Herr Adolf Hitler");
            }
            else
            {
                Console.WriteLine("Heil Mein Fuhrer");
            }

            Console.ReadKey();

        }
    }
}