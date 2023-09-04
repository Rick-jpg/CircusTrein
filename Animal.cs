using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public AnimalType type { get; private set; }

        public AnimalSize size { get; private set; }
        private float test;

        public Animal() { }
        public Animal(AnimalType type, AnimalSize size, float test)
        {
            this.type = type;
            this.size = size;
            this.test = test;
        }
        public override string ToString()
        {
            string result = $" {size}.{type}  ";
            return result + "";
        }
    }
}
