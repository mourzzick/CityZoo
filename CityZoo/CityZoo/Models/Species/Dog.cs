using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Dog : Mammal
    {
        private string breed;

        /// <summary>
        /// Gets or sets the dog's breed.
        /// </summary>
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        /// <summary>
        /// Initializes a new instance of the dog class.
        /// </summary>
        public Dog(string name, double age, Sex sex, int numberOfTeeth, string breed) : base(name, age, sex, numberOfTeeth)
        {
            this.Breed = breed;
        }

        /// <summary>
        /// Returns a string that represents the cat object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Is a {this.Breed}";
        }

    } // end class
}
