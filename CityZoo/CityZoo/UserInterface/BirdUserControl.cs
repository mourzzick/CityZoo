using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityZoo.GUI
{
    public partial class BirdUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the BirdUserControl class.
        /// </summary>
        public BirdUserControl()
        {
            InitializeComponent();
            Clear();
        }

        /// <summary>
        /// Gets the Bird flying speed as an integer value.
        /// </summary>
        public int FlyingSpeed
        {
            get
            {
                int flyingSpeed;
                bool isSuccessful = Int32.TryParse(txtFlyingSpeed.Text.Trim(), out flyingSpeed);
                if (isSuccessful)
                {
                    return flyingSpeed;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Gets the Bird wingspan as an integer value.
        /// </summary>
        public int Wingspan
        {
            get
            {
                int wingspan;
                bool isSuccessful = Int32.TryParse(txtWingspan.Text.Trim(), out wingspan);
                if (isSuccessful)
                {
                    return wingspan;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Clears all BirdUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtFlyingSpeed.Text = string.Empty;
            txtWingspan.Text = string.Empty;
        }


    } // end class
}
