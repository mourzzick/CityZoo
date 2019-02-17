using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Animal
    {
        // Animal fields
        private int id;
        private string name;
        private double age;
        private Sex sex;

        /// <summary>
        /// Gets or sets the Animal ID number.
        /// </summary>
        public int Id
        {
            get { return id; }
            set
            {
                if (id > 0)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Animal name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Animal age.
        /// </summary>
        public double Age
        {
            get { return age; }
            set
            {
                if (value > 0.0)
                {
                    age = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the Animal sex.
        /// </summary>
        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Animal class.
        /// </summary>
        public Animal()
        {
            InitializeVariables();
        }

        /// <summary>
        /// Initializes a new instance of the Animal class.
        /// </summary>
        public Animal(int id, string name, double age, Sex sex) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        /// <summary>
        /// Initializes all Animal fields to default values.
        /// </summary>
        private void InitializeVariables()
        {
            this.Id = 1;
            this.Name = "No name";
            this.Age = 0.1;
            this.Sex = Sex.Other;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            return $"{id}, {name}, {age}, {sex}";
        }
    }
}
