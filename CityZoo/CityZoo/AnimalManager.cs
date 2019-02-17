using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class AnimalManager
    {
        private List<Animal> animalList;

        public AnimalManager()
        {
            animalList = new List<Animal>();
            

        }

       




        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                animalList.Add(animal);
            }
        }
    }
}
