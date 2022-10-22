using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Ford : Car
    {
        public string Type;

        public Ford(int year, string name,string color, string brand, int hp, string type) : base(year, name, color, brand, hp)
        {
            Type = type;
        }

        public void FordFans()
        {
            Console.WriteLine($"Yahoo, you are in {Brand} {Type} member clan!.");
        }
    }
}
