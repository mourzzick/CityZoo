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
        /// <param name="mammalSpecies"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Mammal CreateMammalSpecies(MammalSpecies mammalSpecies, int id)
        {
            switch (mammalSpecies)
            {
                case MammalSpecies.Dog:
                    return new Dog(id);
                case MammalSpecies.Cat:
                    return new Cat(id);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Create a bird species.
        /// </summary>
        /// <param name="birdSpecies"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Bird CreateBirdSpecies(BirdSpecies birdSpecies, int id)
        {
            switch (birdSpecies)
            {
                case BirdSpecies.Budgerigar:
                    return new Budgerigar(id);
                case BirdSpecies.Cockatiel:
                    return new Cockatiel(id);
                case BirdSpecies.Cockatoo:
                    return new Cockatoo(id);
                default:
                    return null;
            }
        }


    } // end class
}



