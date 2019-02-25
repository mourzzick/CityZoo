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
        private int animalId;

        public int AnimalId
        {
            get
            {
                animalId++;
                return animalId;
            }
        }



        public AnimalManager()
        {
            animalList = new List<Animal>();
            animalId = 1;
            

        }

        public List<Animal> AnimalList // TODO: remake this to copy the list to array of strings
        {
            get
            {
                return animalList;
            }
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
