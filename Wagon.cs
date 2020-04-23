using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        private readonly List<Animal> animals;
        private const int MaxCapacity = 10;
        public int SizeLargestCarnivore { get; private set; }
        public int SizeSmallestHerbivore { get; private set; }
        public int Total { get; private set; }

        public Wagon()
        {
            animals = new List<Animal>();
            SizeLargestCarnivore = 0;
            SizeSmallestHerbivore = MaxCapacity;
        }
         public bool CanFitAnimal(Animal animal)
        {
            if (Total + (int)animal.size > MaxCapacity) return false;
            if((animal.type == AnimalType.Carnivore) && (SizeSmallestHerbivore <= (int)animal.size)) return false;
            if ((animal.type == AnimalType.Carnivore) && (SizeLargestCarnivore >= (int)animal.size)) return false;
            if ((animal.type == AnimalType.Herbivore) && (SizeLargestCarnivore >= (int)animal.size)) return false;
            return true;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            Total += (int)animal.size;
            switch (animal.type)
            {
                case AnimalType.Carnivore:
                    SizeLargestCarnivore = (int)animal.size;
                    break;
                case AnimalType.Herbivore:
                    SizeSmallestHerbivore = (int)animal.size;
                    break;                   
            }
        }
        public override string ToString()
        {
            string result = "";
            foreach(Animal animal in animals)
            {
                result += $"{animal.ToString()}";
            }
            return result;
        }
    }
}
