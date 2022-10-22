using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Dog : Animal
    {
        public Dog(int age, string name) : base(age, name) { }

        public void Bark()
        {
            Console.WriteLine($"I'm dog {Name} and i bark.");
        }

        public void Fetch()
        {
            Console.WriteLine($"I'm {Age} years old dog and i can still Fetch some stick.");
        }
    }
}
