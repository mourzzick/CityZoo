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
            switch (mammalSpecies)
            {
                case MammalSpecies.Dog:
                    return new Dog();
                case MammalSpecies.Cat:
                    return new Cat();
                default:
                    return null;


            }
        }


        

        
    }
}
