using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class LeeSin : Champion
    {
        public string Name;
        public string Resource;

        protected int ResourceNumber;

        public LeeSin(int armor, int attackDamage, int movementSpeed, int health, int resourceNumber, string name, string resource) : base(armor, attackDamage, movementSpeed, health, resourceNumber)
        {
            Name = name;
            Resource = resource;
            ResourceNumber = resourceNumber;
        }

        public void SonicWave(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name Sonic Wave and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
            Flurry();
        }

        public void Safeguard(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name Safeguard( and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
            Flurry();
        }

        public void Tempest(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name Tempest and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
            Flurry();
        }

        public void DragonsRage(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name  Dragon's Rage and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
            Flurry();
        }

        public void Flurry(int value = 25)
        {
            Console.WriteLine($"You have used buffed attack, u have restored {value} {Resource}.");
            ResourceNumber += value;
            if (ResourceNumber > 200)
                ResourceNumber = 200;
            Console.WriteLine($"You have already {ResourceNumber} {Resource}");
        }
    }
}
