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
    public partial class RecipeForm : Form
    {
        Recipe recipe;

        /// <summary>
        /// Initializes a new instance of the RecipeForm class.
        /// </summary>
        public RecipeForm()
        {
            InitializeComponent();
            InitializeGUI();
            recipe = new Recipe();
        }

        /// <summary>
        /// Gets a recipe
        /// </summary>
        public Recipe Recipe
        {
            get { return recipe; }
        }

        /// <summary>
        /// Initializes all RecipeForm controls to their default state.
        /// </summary>
        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtIngredient.Text = string.Empty;
            lbIngredients.Items.Clear();

        }

       /// <summary>
       /// Reads the recipe name data, adds ingredient to the recipe
       /// and displays the information to the user
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReadName() && ReadIngredient())
            {
                UpdateGUI();
            }
        }

        /// <summary>
        /// Reads the recipe name and adds it inside the recipe object
        /// </summary>
        private bool ReadName()
        {
            string name = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(name)) {
                recipe.Name = name;
                return true;
            }
            return false;

        }

        /// <summary>
        /// Reads the ingredients and adds to the list inside the recipe object
        /// </summary>
        /// <returns></returns>
        private bool ReadIngredient()
        {
            string ingredient = txtIngredient.Text.Trim();
            if (!string.IsNullOrEmpty(ingredient))
            {
                recipe.Add(ingredient);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Updates the GUI after reading the recipe object
        /// </summary>
        private void UpdateGUI()
        {
            lbIngredients.Items.Clear();
            txtName.Text = recipe.Name;
            txtIngredient.Text = string.Empty;
            lbIngredients.Items.AddRange(recipe.ToStringArray());
        }

        /// <summary>
        /// Deletes a selected ingredient from the list of ingredients inside the recipe object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbIngredients.SelectedIndex;
            if (recipe.IsValidIndex(index) && index > -1)
            {
                recipe.DeleteAt(index);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Changes a selected ingredient inside the recipe object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lbIngredients.SelectedIndex;
            if (recipe.IsValidIndex(index) && index > -1)
            {
                recipe.ChnageAt(txtIngredient.Text, index);
                UpdateGUI();
            }


        } // end class
    }
}
