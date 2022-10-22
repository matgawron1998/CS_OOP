using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Car : Vehicle
    {
        public string Brand;
        public int HP;

        public Car(int year, string name, string color, string brand, int hp) : base(year, name, color)
        { 
            Brand = brand;
            HP = hp;
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} car with {HP} horspower went wroom wroom.");
        }
    }
}
