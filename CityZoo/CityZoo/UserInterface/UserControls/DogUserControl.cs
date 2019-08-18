using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityZoo.UserInterface
{
    public partial class DogUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the DogUserControl class.
        /// </summary>
        public DogUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the dog breed.
        /// </summary>
        public string Breed
        {
            get { return txtBreed.Text.Trim(); }
        }

        /// <summary>
        /// Clears all DogUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtBreed.Text = string.Empty;
        }

    } // end class
}


