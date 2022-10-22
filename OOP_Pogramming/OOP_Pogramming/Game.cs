using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Game
    {
        public string Name;
        public int ProductionYear;
        public int Price;

        public void DisplayPrice()
        {
            Console.WriteLine($"The price of this game ios {Price}");
        }

        public void DisplayContents() 
        {
            Console.WriteLine($"Name of this game is {Name}, production year is {ProductionYear}");
        }
    }
}
