using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Bird : Animal
    {
        // bird fields
        private int flyingSpeed; // unit km/h
        private int wingspan; // unit cm

        /// <summary>
        /// Gets or sets the Bird flying speed.
        /// </summary>
        public int FlyingSpeed
        {
            get { return flyingSpeed; }
            set
            {
                if (value > 0)
                {
                    flyingSpeed = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Bird wingspan.
        /// </summary>
        public int Wingspan
        {
            get { return wingspan; }
            set
            {
                if (value > 0)
                {
                    wingspan = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Bird class.
        /// </summary>
        public Bird(int id) : base(id)
        {

        }


        /// <summary>
        /// Returns a string that represents the Bird object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.Id,-10} {this.Name,-20} {this.Age,-10} {this.Sex,-15} Flies with {this.flyingSpeed} km/h. Wingspan is {this.wingspan} cm.";
        }





    }
}
