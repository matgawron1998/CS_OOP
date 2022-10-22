using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Zoo
    {
        private string Name;
        private List<Animal> animals = new List<Animal>();

        public Zoo(string name)
        { 
            Name = name;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void DisplayAnimals()
        {
            animals.ForEach(animal => Console.WriteLine($"{animal.Name}"));
        }
    }
}
