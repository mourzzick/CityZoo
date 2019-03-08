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

        /// <summary>
        /// Gets or sets the bird's flying speed.
        /// </summary>
        public int FlyingSpeed
        {
            get { return flyingSpeed; }
            set { flyingSpeed = value; }
         
        }

        /// <summary>
        /// Initializes a new instance of the bird class.
        /// </summary>
        public Bird(string name, double age, Sex sex, int flyingSpeed) : base(name, age, sex)
        {
            this.FlyingSpeed = flyingSpeed;
        }

        /// <summary>
        /// Returns a string that represents the bird object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Flies with {this.FlyingSpeed} km/h."; 
        }

    }
}
