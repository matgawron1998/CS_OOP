using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Installer
    {
        public static void GameTask()
        {
            Game Cyber = new Game();
            Game Diablo4 = new Game();

            Cyber.Name = "Cyberpunk 2077";
            Cyber.ProductionYear = 2020;
            Cyber.Price = 199;

            Diablo4.Name = "Diablo 4";
            Diablo4.ProductionYear = 2023;
            Diablo4.Price = 299;

            Cyber.DisplayPrice();
            Cyber.DisplayContents();

            Diablo4.DisplayPrice();
            Diablo4.DisplayContents();
        }

        public static void BankAccountTask()
        {
            BankAccount bankAccount = new BankAccount("Mateusz", "Gawron", "2345");
            bankAccount.Status();
            bankAccount.Deposit(200);
            bankAccount.Status();
            bankAccount.WithDrawal(150);
            bankAccount.Status();
        }
        public static void ZooTask()
        {
            Zoo zoo = new Zoo("Zoo in Wroclaw");

            Animal parrot = new Animal(3, "Parrot");
            Animal tiger = new Animal(4, "Tiger");

            zoo.AddAnimal(parrot);
            zoo.AddAnimal(tiger);

            Console.WriteLine($"Animals in our zoo: ");
            zoo.DisplayAnimals();

            zoo.RemoveAnimal(tiger);

            Console.WriteLine($"Animals in our zoo in this moment: ");
            zoo.DisplayAnimals();
        }
        public static void VehicleTask()
        {
            Bike Giant = new Bike(200, "Wheely", "Red", "Yamuha");

            Giant.Parameters();
            Giant.Condition();
            Giant.DisplayWheels();

            Car Ford = new Car(2014, "Fordy", "Blue", "Arrela", 250);

            Ford.Parameters();
            Ford.Condition();
            Ford.Drive();
        }
        public static void DravenTask()
        {
            Draven draven = new Draven(29, 60, 330, 574, 400, "Draven", "mana");

            draven.SpinningAxe(45);
            draven.StandAside(70);
            draven.BloodRush(40);
            draven.WhirlingDeath(100);
            draven.ResourcePotion();
        }
        public static void LeeSinTask()
        {
            LeeSin leesin = new LeeSin(33, 70, 345, 575, 200, "Lee Sin", "energy");

            leesin.SonicWave(50);
            leesin.Safeguard(50);
            leesin.Tempest(50);
            leesin.DragonsRage(0);
        }
    }
}
