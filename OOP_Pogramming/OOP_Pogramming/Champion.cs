using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Champion
    {
        protected int Armor;
        protected int AttackDamage;
        protected int MovementSpeed;
        protected int Health;
        protected int ResourceNumber;

        public Champion(int armor, int attackdamage, int movementSpeed, int health, int resourceNumber)
        { 
            Armor = armor;
            AttackDamage = attackdamage;
            MovementSpeed = movementSpeed;
            Health = health;
            ResourceNumber = resourceNumber;
        }
    }
}
