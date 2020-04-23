using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public static class AnimalCreator
    {
        private static Random random = new Random();
        public static Animal GenerateRandomAnimals()
        {
            Array sizeValues = Enum.GetValues(typeof(AnimalSize));
            var type = (AnimalType)random.Next(Enum.GetValues(typeof(AnimalType)).Length);
            var size = (AnimalSize)sizeValues.GetValue(random.Next(sizeValues.Length));
            var animal = new Animal(type, size);
            return animal;
        }
    }
}
