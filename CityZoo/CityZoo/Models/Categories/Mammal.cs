using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Mammal : Animal
    {
        // Mammal field
        private int numberOfTeeth;
        private int tailLength; // in centimeters

        /// <summary>
        /// Gets or sets the Mammal number of teeth.
        /// </summary>
        public int NumberOfTeeth
        {
            get { return numberOfTeeth; }
            set
            {
                if (value > 0)
                {
                    numberOfTeeth = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Mammal tail length.
        /// </summary>
        public int TailLength
        {
            get { return tailLength; }
            set
            {
                if (value > 0)
                {
                    tailLength = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Mammal class.
        /// </summary>
        public Mammal(int id) : base(id)
        {

        }


      

    

    } // end class
}
