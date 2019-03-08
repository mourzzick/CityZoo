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
    public partial class EagleUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the EagleUserControl class.
        /// </summary>
        public EagleUserControl()
        {
            InitializeComponent();
            Clear();
        }

        /// <summary>
        /// Gets the eagle wingspan as an integer value.
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
        /// Clears all EagleUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtWingspan.Text = string.Empty;
        }
    }
}
