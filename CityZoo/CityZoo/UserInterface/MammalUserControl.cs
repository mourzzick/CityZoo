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
    public partial class MammalUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the MammalUserControl class.
        /// </summary>
        public MammalUserControl()
        {
            InitializeComponent();
            Clear();

        }

        /// <summary>
        /// Gets the Mammal number of teeth as an integer value.
        /// </summary>
        public int NumberOfTheet
        {
            get
            {
                int numberOfTeeth;
                bool isSuccessful = Int32.TryParse(txtNumberOfTeeth.Text.Trim(), out numberOfTeeth);
                if (isSuccessful)
                {
                    return numberOfTeeth;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Gets the Mammal tail length as an integer value.
        /// </summary>
        public int TailLength
        {
            get
            {
                int tailLenght;
                bool isSuccessful = Int32.TryParse(txtTailLength.Text.Trim(), out tailLenght);
                if (isSuccessful)
                {
                    return tailLenght;
                }
                else
                {
                    return -1;
                }
            }
        }

        /// <summary>
        /// Clears all MammalUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtNumberOfTeeth.Text = string.Empty;
            txtTailLength.Text = string.Empty;
        }


    } // end class
}
