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
        public MammalUserControl()
        {
            InitializeComponent();
        }

       

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




    }
}
