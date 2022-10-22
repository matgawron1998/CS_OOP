using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Bike : Vehicle
    {
        public string Brand;
        public Bike(int year, string name, string color, string brand) : base(year, name, color)
        {
            Brand = brand;
            Name = name;
        }

        public void DisplayWheels()
        {
            Console.WriteLine($"{Brand} bicycle has 2 wheels and 1 handlebar.");
        }
    }
}
