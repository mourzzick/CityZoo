using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityZoo.Models.Species
{
    public partial class BudgerigarUserControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the BudgerigarUserControl class.
        /// 
        /// </summary>
        public BudgerigarUserControl()
        {
            InitializeComponent();
            Clear();
        }

        /// <summary>
        /// Gets the budgerigar color.
        /// </summary>
        public string Color
        {
            get { return txtColor.Text.Trim(); }
        }
      
        /// <summary>
        /// Clears all BudgerigarUserControl input controls
        /// </summary>
        public void Clear()
        {
            txtColor.Text = string.Empty;
        }

    } // end class
}
