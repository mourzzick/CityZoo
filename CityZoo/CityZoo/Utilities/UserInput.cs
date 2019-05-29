// Ruslan Georgiev
// Canvas id: aj0701


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class UserInput
    {
        // TODO: I'm unsure what type of data is this object suppose to carry.
        // Is it just text form input controls or appropriate types for each model object.
        public string Name { get; set; }
        public double Age { get; set; }
        public Sex Sex { get; set; }
        public int NumberOfTeeth { get; set; } // from Mammal 
        public int FlyingSpeed { get; set; } // from Bird
        public int TailLength { get; set; } // from Cat
        public string Breed { get; set; } // from God
        public string Color { get; set; } // from Budgerigar
        public int Wingspan { get; set; } // from Eagle


    } // end class
}
