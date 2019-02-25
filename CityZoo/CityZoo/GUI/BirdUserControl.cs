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
                string input = txtFlyingSpeed.Text;
                if (!string.IsNullOrEmpty(input))
                {
                    return int.Parse(input);
                }
                else
                {
                    return 0;
                }
            }
        }


        public int Wingspan
        {
            get
            {
                string input = txtWingspan.Text;
                if (!string.IsNullOrEmpty(input))
                {
                    return int.Parse(input);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
