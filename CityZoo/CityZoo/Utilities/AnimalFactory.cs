using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    static class AnimalFactory
    {
        /// <summary>
        /// Creates a mammal species.
        /// </summary>
        public static Mammal CreateMammalSpecies(MammalSpecies mammalSpecies, UserInput userInput)
        {
            switch (mammalSpecies)
            {
                case MammalSpecies.Dog:
                    return new Dog(userInput.Name, userInput.Age, userInput.Sex, userInput.NumberOfTeeth, userInput.Breed);
                case MammalSpecies.Cat:
                    return new Cat(userInput.Name, userInput.Age, userInput.Sex, userInput.NumberOfTeeth, userInput.TailLength);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Create a bird species.
        /// </summary>
        public static Bird CreateBirdSpecies(BirdSpecies birdSpecies, UserInput userInput)
        {
            switch (birdSpecies)
            {
                case BirdSpecies.Budgerigar:
                    return new Budgerigar(userInput.Name, userInput.Age, userInput.Sex, userInput.FlyingSpeed, userInput.Color);
                case BirdSpecies.Eagle:
                    return new Eagle(userInput.Name, userInput.Age, userInput.Sex, userInput.FlyingSpeed, userInput.Wingspan);
                default:
                    return null;
            }
        }


    } // end class
}



