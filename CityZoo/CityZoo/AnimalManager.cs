using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class AnimalManager
    {
        private List<Animal> animals;

        public AnimalManager()
        {
            animals = new List<Animal>();
        }


        public void Add(Animal animal)
        {
            if (animal != null)
            {
                animals.Add(animal);
            }
        }
    }
}
