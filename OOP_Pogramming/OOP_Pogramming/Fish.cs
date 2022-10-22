using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Fish : Animal
    {
        public Fish(int age, string name) : base(age, name) { }

        public void Swim()
        {
            Console.WriteLine($"I'm fish {Name} and i swim.");
        }

        public void Gills()
        {
            Console.WriteLine($"I'm {Age} years old angry fish and i have gills.");
        }
    }
}
