using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Animal
    {
        private int id;
        private string name;
        private double age;
        private Category category; // taxonomic class (mammal, bird, etc.)
        private Sex sex;

        public Animal()
        {
            id = 0;
            name = "Tom";
            age = 0.0;
            category = Category.Mammal;
            sex = Sex.Male; 
        }
    }
}
