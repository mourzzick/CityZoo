using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Eagle : Bird
    {
        private int wingspan; // unit cm

        /// <summary>
        /// Gets or sets the eagle's wingspan.
        /// </summary>
        public int Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }

        }

        /// <summary>
        /// Initializes a new instance of the eagle class.
        /// </summary>
        public Eagle(string name, double age, Sex sex, int flyingSpeed, int wingspan) : base(name, age, sex, flyingSpeed)
        {
            this.Wingspan = wingspan;
        }

        /// <summary>
        /// Returns a string that represents the eagle object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Has {this.Wingspan} cm wingspan.";
        }

    } // end class
}
