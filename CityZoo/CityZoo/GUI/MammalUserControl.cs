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
                string input = txtNumberOfTeeth.Text;
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


        public int TailLength
        {
            get
            {
                string input = txtTailLength.Text;
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
