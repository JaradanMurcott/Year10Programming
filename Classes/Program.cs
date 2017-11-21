using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Klaas", "Bootsma", 35);
        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool sitting;
        private int steps;

        public Person(string firstName, string lastName, int age);
        
        
    }
}
