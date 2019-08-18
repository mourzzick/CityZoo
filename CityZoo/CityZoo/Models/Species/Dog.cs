// Ruslan Georgiev
// Canvas id: aj0701


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Dog : Mammal
    {
        private string breed;

        /// <summary>
        /// Gets or sets the dog's breed.
        /// </summary>
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        /// <summary>
        /// Initializes a new instance of the dog class.
        /// </summary>
        public Dog(string name, double age, Sex sex, int numberOfTeeth, string breed) : base(name, age, sex, numberOfTeeth)
        {
            this.Breed = breed;
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
            foodSchedule.AddFoodScheduleItem("Morning: dog food");
            foodSchedule.AddFoodScheduleItem("Lunch: bones");
            return foodSchedule;
        }

        /// <summary>
        /// Returns a string that represents the cat object.
        /// </summary>
        public override string ToString()
        {
            return $"{base.ToString()} Is a {this.Breed}";
        }


    } // end class
}
