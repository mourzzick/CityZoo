using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Cat : Mammal
    {
        private int tailLength; // in centimeters

        /// <summary>
        /// Gets or sets the cat's tail length.
        /// </summary>
        public int TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        /// <summary>
        /// Initializes a new instance of the cat class.
        /// </summary>
        public Cat(string name, double age, Sex sex, int numberOfTeeth, int tailLength) : base(name, age, sex, numberOfTeeth)
        {
            this.TailLength = tailLength;
        }

        /// <summary>
        /// Returns a string that represents the cat object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Has {this.TailLength} cm long tail.";
        }


    } // end class
}
