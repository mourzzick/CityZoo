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
        public Mammal() // TODO: Might have to change the constructor and call the base constructor
        {
            InitializeVariables();
        }

        /// <summary>
        /// Initializes a new instance of the Mammal class.
        /// </summary>
        public Mammal(int numberOfTeeth, int tailLength) : this() // TODO: Might have to change the constructor and call the base constructor
        {
            this.NumberOfTeeth = numberOfTeeth;
            this.TailLength = tailLength;
        }

        /// <summary>
        /// Initializes all Mammal fields to a default values.
        /// </summary>
        private void InitializeVariables()
        {
            this.NumberOfTeeth = 1;
            this.TailLength = 1;

        }

    }
}
