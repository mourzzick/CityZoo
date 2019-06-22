using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo.Models
{
    public class Recipe : ListManager<string>
    {
        /// <summary>
        /// Initializes a new instance of the recipe class.
        /// </summary>
        public Recipe()
        {

        }

        /// <summary>
        /// Gets or sets the recipe name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the recipe object.
        /// </summary>
        public override string ToString()
        {
            StringBuilder ingredients = new StringBuilder();
            for (int i = 0; i < base.Count; i++) {
                ingredients.Append(", ").Append(base.GetAt(i));
            }
            return $"{Name}{ingredients}";
        }


    }
}
