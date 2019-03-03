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

        /// <summary>
        /// Initializes a new instance of the BirdUserControl class.
        /// </summary>
        public AnimalManager()
        {
            animalList = new List<Animal>();
            animalId = 0; // default animal id value

        }

        /// <summary>
        /// Gets the animal list.
        /// </summary>
        public List<Animal> AnimalList // TODO: remake this to copy the list to array of strings
        {
            get
            {
                return animalList;
            }
        }

        /// <summary>
        /// Adds animal to the animal manager.
        /// </summary>
        /// <param name="animal"></param>
        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                animalList.Add(animal);
            }
        }
    }
}
