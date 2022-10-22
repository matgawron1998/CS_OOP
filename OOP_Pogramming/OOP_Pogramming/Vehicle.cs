using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Vehicle
    {
        protected int Year;
        protected string Name;
        protected string Color;

        public Vehicle(int year, string name, string color)
        { 
            Year = year;
            Name = name;
            Color = color;
        }

        public void Parameters()
        { 
            Console.WriteLine($"Year of production: {Year}\nName: {Name}\nColor: {Color}");
        }

        public void Condition()
        {
            if (Year == 11)
            {
                Console.WriteLine("New one");
                return;
            }
            Console.WriteLine("Old one");
        }
    }
}
