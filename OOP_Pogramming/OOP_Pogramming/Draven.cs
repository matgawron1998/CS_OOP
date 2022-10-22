using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Draven : Champion
    {
        public string Name;
        public string Resource;

        protected int ResourceNumber;

        public Draven(int armor, int attackDamage, int movementSpeed, int health, int resourceNumber, string name, string resource) : base(armor, attackDamage, movementSpeed, health, resourceNumber)
        {
            Name = name;
            Resource = resource;
            ResourceNumber = resourceNumber;
        }

        public void SpinningAxe(int cost)
        { 
            Console.WriteLine($"This {Name}'s spell is name Spining Axe and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
        }

        public void BloodRush(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name Blood Rush( and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
        }

        public void StandAside(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name Stand Aside and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
        }

        public void WhirlingDeath(int cost)
        {
            Console.WriteLine($"This {Name}'s spell is name  Whirling Death and costs {cost} {ResourceNumber}");
            ResourceNumber -= cost;
            Console.WriteLine($"You have already {ResourceNumber}{Resource}");
        }

        public void ResourcePotion()
        {
            Console.WriteLine($"You have drank potion of {Resource}.");
            ResourceNumber += 100;
            Console.WriteLine($"You have already {ResourceNumber} {Resource}");
        }
    }
}
