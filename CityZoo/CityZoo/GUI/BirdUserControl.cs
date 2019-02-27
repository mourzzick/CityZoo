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
        public BirdUserControl()
        {
            InitializeComponent();
        }

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


   
    }
}
