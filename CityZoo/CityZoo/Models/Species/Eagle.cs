// Ruslan Georgiev
// Canvas id: aj0701


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
        /// Gets the name of the species
        /// </summary>
        // TODO: looks like this method fits better in the Animal class
        public override string GetSpecies()
        {
            return this.GetType().Name;
        }

        /// <summary>
        /// Gets the eater type of the species
        /// </summary>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

        /// <summary>
        /// Gets species food schedule
        /// </summary>
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Morning: mice");
            foodSchedule.AddFoodScheduleItem("Lunch: rabbit");
            return foodSchedule;
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
