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

        /// <summary>
        /// Gets and sets the bird's color
        /// </summary>
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
            return EaterType.Omnivorus;
        }

        /// <summary>
        /// Gets species food schedule
        /// </summary>
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Morning: seeds");
            foodSchedule.AddFoodScheduleItem("Lunch: insects");
            return foodSchedule;
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
