using CityZoo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo.Models
{
    public class Staff : ListManager<string>
    {
        private string name;
        private IListManager<string> qualifications;

        /// <summary>
        /// Initializes a new instance of the Staff class.
        /// </summary>
        public Staff()
        {
            qualifications = new ListManager<string>();
        }

        /// <summary>
        /// Gets or sets the stuff name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Returns a string that represents the stuff object.
        /// </summary>
        public override string ToString()
        {
            StringBuilder qualifications = new StringBuilder();
            for (int i = 0; i < base.Count; i++)
            {
                qualifications.Append(", ").Append(base.GetAt(i));
            }
            return $"{Name}{qualifications}";
        }


    } // end class
}
