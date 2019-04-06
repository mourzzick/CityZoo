using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    abstract class Mammal : Animal
    {
        // mammal fields
        private int numberOfTeeth;
       
        /// <summary>
        /// Gets or sets the mammal number of teeth.
        /// </summary>
        public int NumberOfTeeth
        {
            get { return numberOfTeeth; }
            set { numberOfTeeth = value; }
        }

        /// <summary>
        /// Initializes a new instance of the mammal class.
        /// </summary>
        public Mammal(string name, double age, Sex sex, int numberOfTeeth) : base(name, age, sex)
        {
            this.NumberOfTeeth = numberOfTeeth;
        }

        /// <summary>
        /// Returns a string that represents the mammal object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Has {this.NumberOfTeeth} teeth.";
        }


    } // end class
}
