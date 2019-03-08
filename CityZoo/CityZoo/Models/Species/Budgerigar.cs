using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Budgerigar : Bird
    {
        private string color;

        // Gets and sets the bird's color
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Initializes a new instance of the budgerigar class.
        /// </summary>
        public Budgerigar(string name, double age, Sex sex, int flyingSpeed, string color) : base(name, age, sex, flyingSpeed)
        {
            this.Color = color;
        }

        /// <summary>
        /// Returns a string that represents the budgerigar object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} It is {this.Color} color.";
        }


    } // end class
}
