using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Animal
    {
        public int Age;
        public string Name;

        public Animal(int age, string name)
        { 
            Age = age;
            Name = name;
        }

        public void Eat()
        {
            for (int i = 0; i < 2, i++)
            {
                Console.WriteLine("Om Nom Nom");
            }
        }

        public void Drink()
        { 
            Console.WriteLine("Chlip Chlip Chlip");
        }

        public void Sleep()
        { 
            Console.WriteLine($"An {Age} years old {Name} goes sleep.");
        }
    }
}
