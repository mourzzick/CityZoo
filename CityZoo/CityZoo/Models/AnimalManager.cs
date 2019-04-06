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

        /// <summary>
        /// Initializes a new instance of the BirdUserControl class.
        /// </summary>
        public AnimalManager()
        {
            animalList = new List<Animal>();
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
        /// Gets the animal list as a string array.
        /// </summary>
        public string[] GetAnimalList()
        {
            int numberOfItems = animalList.Count;
            string[] output = new string[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                output[i] = animalList[i].ToString();
            }
            return output;
        }

        /// <summary>
        /// Gets the animal at the specified index position.
        /// </summary>
        public Animal GetAnimalAt(int index) // TODO: I don't like returning the animal reference
        {
            if (index >= 0 && index < animalList.Count)
            {
                Animal animal = animalList[index];
                return animal;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Adds an animal to the animal manager, adds animal id.
        /// </summary>
        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                animal.Id = GenerateAnimalId();
                animalList.Add(animal);
            }
        }


    } // end class
}
