using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    static class AnimalFactory
    {
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

    } // end class
}



