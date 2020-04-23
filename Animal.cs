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

        public Animal() { }
        public Animal(AnimalType type, AnimalSize size)
        {
            this.type = type;
            this.size = size;
        }
        public override string ToString()
        {
            string result = $" {size}.{type}  ";
            return result + "";
        }
    }
}
