using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    static class AnimalFactory
    {
        public static Mammal CreateMammalSpecies(MammalSpecies mammalSpecies)
        {
            Mammal mammal;
            switch (mammalSpecies)
            {
                case MammalSpecies.Dog:
                    mammal = new Dog();
                    break;
                case MammalSpecies.Cat:
                    mammal = new Cat();
                    break;
                default:
                    mammal = new Mammal();
                    break;
            }
            return mammal;
        }


        
    }
}
