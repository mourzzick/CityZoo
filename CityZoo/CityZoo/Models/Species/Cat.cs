using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Cat : Mammal
    {
        private int tailLength; // in centimeters

        /// <summary>
        /// Gets or sets the cat's tail length.
        /// </summary>
        public int TailLength
        {
            get { return tailLength; }
            set { tailLength = value; }
        }

        /// <summary>
        /// Initializes a new instance of the cat class.
        /// </summary>
        public Cat(string name, double age, Sex sex, int numberOfTeeth, int tailLength) : base(name, age, sex, numberOfTeeth)
        {
            this.TailLength = tailLength;
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
            foodSchedule.AddFoodScheduleItem("Morning: cat food");
            foodSchedule.AddFoodScheduleItem("Lunch: egg");
            return foodSchedule;
        }

        /// <summary>
        /// Returns a string that represents the cat object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Has {this.TailLength} cm long tail.";
        }


    } // end class
}
