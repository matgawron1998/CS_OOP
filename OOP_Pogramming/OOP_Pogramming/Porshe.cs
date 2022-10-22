using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Porshe : Car
    {
        public string Type;

        public Porshe(int year, string name, string color, string brand, int hp, string type) : base(year, name, color, brand, hp)
        {
            Type = type;
        }

        public void PorsheClub()
        {
            Console.WriteLine($"Yahoo, tou are in {Brand} {Type} member clan!");
        }
    }
}
