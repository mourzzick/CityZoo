using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    abstract class Animal : IAnimal
    {
        // Animal fields
        private int id;
        private string name;
        private double age;
        private Sex sex;

        /// <summary>
        /// Gets or sets the animal ID number.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the animal name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the animal age.
        /// </summary>
        public double Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Gets or sets the animal sex.
        /// </summary>
        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        /// Initializes a new instance of the animal class.
        /// </summary>
        public Animal(string name, double age, Sex sex)
        {
            InitializeVariables(); // TODO: remove when done
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        /// <summary>
        /// Initializes all animal fields to default values.
        /// </summary>
        private void InitializeVariables()
        {
            this.Name = "No name";
            this.Sex = Sex.Other;
        }

        /// <summary>
        /// Gets the animal eater type
        /// </summary>
        public abstract EaterType GetEaterType();

        /// <summary>
        /// Gets the animal food schedule
        /// </summary>
        public abstract FoodSchedule GetFoodSchedule();
     
        /// <summary>
        /// Gets the animal species
        /// </summary>
        public abstract string GetSpecies();

        /// <summary>
        /// Returns a string that represents the animal object.
        /// </summary>
        public override string ToString()
        {
            return $"{this.Id,-7}{this.Name,-18}{this.Age,-7}{this.Sex,-10}";
        }

        
    } // end class
}
