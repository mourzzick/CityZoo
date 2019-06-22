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

        public RecipeForm()
        {
            InitializeComponent();
            InitializeGUI();
            recipe = new Recipe();
        }

        public Recipe Recipe
        {
            get { return recipe; }
        }

        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtIngredient.Text = string.Empty;
            lbIngredients.Items.Clear();

        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReadName() && ReadIngredient())
            {
                UpdateGUI();
            }

          
            
        }

        private bool ReadName()
        {
            string name = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(name)) {
                recipe.Name = name;
                return true;
            }
            return false;

        }

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

        private void UpdateGUI()
        {
            lbIngredients.Items.Clear();
            txtName.Text = recipe.Name;
            txtIngredient.Text = string.Empty;
            lbIngredients.Items.AddRange(recipe.ToStringArray());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbIngredients.SelectedIndex;
            if (recipe.IsValidIndex(index) && index > -1)
            {
                recipe.DeleteAt(index);
                UpdateGUI();
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int index = lbIngredients.SelectedIndex;
            if (recipe.IsValidIndex(index) && index > -1)
            {
                recipe.ChnageAt(txtIngredient.Text, index);
                UpdateGUI();
            }


        }
    }
}
