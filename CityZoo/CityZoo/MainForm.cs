using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityZoo
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager;
        Animal animal;

        public MainForm()
        {
            animalManager = new AnimalManager();
            animal = new Animal();
            animal.ToString();

            InitializeComponent();
            InitializeGUI();


        }




        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtNumberOfTeeth.Text = string.Empty;
            txtTailLength.Text = string.Empty;
            PopulateSexComboBox();
            PopulateCategoryComboBox();
            cboSex.Name = "dfsdfvg";

           
        
        }
       

        

        //private bool ReadInput()
        //{
        //    ReadDouble 
        //}

        //private double ReadDouble(string value)
        //{
        //    double number = 0.0;
        //    bool succsess = double.TryParse(value, out number);
        //    if (!succsess)
        //    {
        //        MessageBox.Show()
        //    }
        //}



      


        private void PopulateSexComboBox()
        {
            string[] values = Enum.GetNames(typeof(Sex));
            cboSex.Items.AddRange(values);
        }

        private void PopulateCategoryComboBox()
        {
            string[] values = Enum.GetNames(typeof(Category));
            cboCategory.Items.AddRange(values);
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSpecies.Items.Clear();
            string selectedValue = cboCategory.GetItemText(cboCategory.SelectedItem);
            string[] enumValues;

            switch (selectedValue)
            {
                case "Bird":
                    enumValues = Enum.GetNames(typeof(BirdSpecies));
                    cboSpecies.Items.AddRange(enumValues);
                    break;
                case "Mammal":
                    enumValues = Enum.GetNames(typeof(MammalSpecies));
                    cboSpecies.Items.AddRange(enumValues);
                    break;
            }
        }


        private void AddAnimal()
        {
            string selectedValue = cboCategory.GetItemText(cboCategory.SelectedItem);

            Category category = (Category)Enum.Parse(typeof(Category), selectedValue);

            switch (category)
            {
                case Category.Mammal:
                    selectedValue = cboSpecies.GetItemText(cboSpecies.SelectedItem);
                    MammalSpecies mammalSpecies = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), selectedValue);
                    animal= AnimalFactory.CreateMammalSpecies(mammalSpecies);
                    animal.name = "Ruslan";
                    MessageBox.Show(animal.name);
                   


                    break;
                case Category.Bird:
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            AddAnimal();
        }










        //private void PopulateSpeciesComboBox()
        //{
        //    string[] values = Enum.GetNames(typeof(Species));
        //    cboSex.Items.AddRange(values);
        //}








    }
}
