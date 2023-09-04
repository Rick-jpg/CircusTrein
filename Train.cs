using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
   public class Train
    {
        private readonly List<Wagon> wagons;
        private List<Animal> animals;

        public Train()
        {
            wagons = new List<Wagon>();
            animals = new List<Animal>();
        }
        public void AddAllAnimals(List<Animal> animals)
        {
            this.animals = animals;
            SortAnimals();
        }
        private void SortAnimals()
        {
            var sortedAnimals = animals.OrderByDescending(x => x.size);
            foreach(var animal in sortedAnimals)
            {
                bool AnimalSorted = false;
                foreach(var wagon in wagons)
                {
                    if (wagon.CanFitAnimal(animal))
                    {
                        wagon.AddAnimal(animal);
                        animals.Remove(animal);
                        AnimalSorted = true;
                    }
                }
                if (!AnimalSorted)
                {
                    var wagon = new Wagon();
                    wagon.AddAnimal(animal);
                    wagons.Add(wagon);
                    animals.Remove(animal);
                    //Check Animals
                }
            }
        }
        public override string ToString()
        {
            string result = $"Wagon count: {wagons.Count} ";
            int wagonnumber = 1;
            foreach (Wagon wagon in wagons)
            {
                result += $"Wagon {wagonnumber}:";
                result += $" {wagon.ToString()}";
                
             
                wagonnumber++;
            }
            return result;
        }
    }
}
