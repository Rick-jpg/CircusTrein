using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Program
    {
        private const int maxAnimals = 10;
        private static Train train;
        public static List<Animal> animals;
        static void Main(string[] args)
        {
            train = new Train();
            animals = new List<Animal>();
            PutAnimalsinTrain();
        }
        private static void PutAnimalsinTrain()
        {
            GenerateAllAnimals();
            train.AddAllAnimals(animals);
            Console.WriteLine(train.ToString());
            Console.ReadKey();
                
        }
        private static void GenerateAllAnimals()
        {
            for (int i = 0; i < maxAnimals ; i++)
            {
                animals.Add(AnimalCreator.GenerateRandomAnimals());
            }
        }
    }
}
