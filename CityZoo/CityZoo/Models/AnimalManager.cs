// Ruslan Georgiev
// Canvas id: aj0701


using CityZoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class AnimalManager : ListManager<Animal>
    {
        private int animalId;
        

        /// <summary>
        /// Initializes a new instance of the AnimalManager class.
        /// </summary>
        public AnimalManager()
        {
            animalId = 0; // default animal id value
        }

        /// <summary>
        /// Generates new animal id.
        /// </summary>
        private int GenerateAnimalId()
        {
            animalId++;
            return animalId;
        }

        /// <summary>
        /// Adds an animal to the animal manager, adds animal id.
        /// </summary>
        public override bool Add(Animal animal)
        {
            if (animal != null)
            {
                animal.Id = GenerateAnimalId();
                return base.Add(animal);
            }
            return false;
        }


    } // end class
}
