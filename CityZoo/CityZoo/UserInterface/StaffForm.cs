using CityZoo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityZoo.UserInterface
{
    public partial class StaffForm : Form
    {
        Staff staff;

        /// <summary>
        /// Initializes a new instance of the StaffForm class.
        /// </summary>
        public StaffForm()
        {
            InitializeComponent();
            InitializeGUI();
            staff = new Staff();
        }

        /// <summary>
        /// Gets staff
        /// </summary>
        public Staff Staff
        {
            get { return staff; }
        }

        /// <summary>
        /// Initializes all StaffForm controls to their default state.
        /// </summary>
        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtQualification.Text = string.Empty;
            lbQualifications.Items.Clear();
        }

        /// <summary>
        /// Reads the staff name data, adds qualifications and displays
        /// the information to the user
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReadName() && ReadQualification())
            {
                lbQualifications.Items.Clear();
                lbQualifications.Items.AddRange(staff.ToStringArray());
                txtQualification.Text = string.Empty;
            }
        }

        /// <summary>
        /// Reads the staff name and adds it inside the staff object
        /// </summary>
        /// <returns></returns>
        private bool ReadName()
        {
            string name = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                staff.Name = name;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reads the qualification and adds to the list inside the staff object
        /// </summary>
        private bool ReadQualification()
        {
            string qulaification = txtQualification.Text.Trim();
            if (!string.IsNullOrEmpty(qulaification))
            {
                staff.Add(qulaification);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Changes a selected qualification inside the staff object
        /// </summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lbQualifications.SelectedIndex;
            string qualification = txtQualification.Text.Trim();

            if (index > -1 && !string.IsNullOrEmpty(qualification)) 
            {
                staff.ChnageAt(qualification, index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Deletes a selected qualification from the list of qualification inside the staff object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbQualifications.SelectedIndex;
            if (index > -1)
            {
                staff.DeleteAt(index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Updates the GUI after reading the stuff object
        /// </summary>
        private void UpdateGUI()
        {
            lbQualifications.Items.Clear();
            lbQualifications.Items.AddRange(staff.ToStringArray());
            txtQualification.Text = string.Empty;
        }


    } // end class
}
