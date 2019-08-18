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
    public partial class CatUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the CatUserControl class.
        /// </summary>
        public CatUserControl()
        {
            InitializeComponent();
            Clear();
        }

        /// <summary>
        /// Gets the cat tail length as an integer value.
        /// </summary>
        public int TailLength
        {
            get
            {
                int tailLength;
                bool isSuccessful = Int32.TryParse(txtTailLength.Text.Trim(), out tailLength);
                if (isSuccessful)
                {
                    return tailLength;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Clears all CatUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtTailLength.Text = string.Empty;
        }

    } // end class
}


