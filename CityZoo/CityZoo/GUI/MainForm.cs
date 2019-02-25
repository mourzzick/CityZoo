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


        public MainForm()
        {
            animalManager = new AnimalManager();
            InitializeComponent();
            InitializeGUI();



        }




        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;



            PopulateSexComboBox();
            PopulateCategoryComboBox();
            //ShowUserControl();



        }

        private void ShowUserControl()
        {
            int index = cboCategory.SelectedIndex;
            if (index > -1)
            {

                Category category = GetSelectedCategory();




                switch (category)
                {
                    case Category.Mammal:
                        birdUserControl.Hide();
                        mammalUserControl.Show();
                        break;

                    case Category.Bird:
                        mammalUserControl.Hide();
                        birdUserControl.Show();
                        break;


                }
            }
        }











        private void PopulateSexComboBox()
        {
            string[] values = Enum.GetNames(typeof(Sex));
            cboSex.Items.AddRange(values);
            cboSex.SelectedIndex = (int)Sex.Other;

        }

        private void PopulateCategoryComboBox()
        {
            string[] values = Enum.GetNames(typeof(Category));
            cboCategory.Items.AddRange(values);
            cboCategory.SelectedIndex = (int)Category.Mammal;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboCategory.SelectedIndex;
            if (index > -1)
            {
                Category category = GetSelectedCategory();
                cboSpecies.Items.Clear();

                string[] enumValues;

                switch (category)
                {
                    case Category.Bird:
                        enumValues = Enum.GetNames(typeof(BirdSpecies));
                        cboSpecies.Items.AddRange(enumValues);
                        mammalUserControl.Hide();
                        birdUserControl.Show();
                        break;

                    case Category.Mammal:
                        enumValues = Enum.GetNames(typeof(MammalSpecies));
                        cboSpecies.Items.AddRange(enumValues);
                        birdUserControl.Hide();
                        mammalUserControl.Show();
                        break;
                }
            }
        }


     

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int numberOfTeeth;
            int tailLength;
            int flyingSpeed;
            int wingspan;

            Category category = GetSelectedCategory();
            switch (category)
            {
                case Category.Mammal:
                    numberOfTeeth = mammalUserControl.NumberOfTheet;
                    tailLength = mammalUserControl.TailLength;
                    break;
                case Category.Bird:
                    flyingSpeed = birdUserControl.FlyingSpeed;
                    wingspan = birdUserControl.Wingspan;
                    break;
            }

        

            Animal animal;
            switch (category)
            {
                case Category.Mammal:
                    animal = AnimalFactory.CreateMammalSpecies(GetMammalSpecies(), animalManager.AnimalId);
                    animal.Name = name;
                    animal.Age = age;
                   
                    animalManager.AddAnimal(animal);
                    break;
                case Category.Bird:
                    
                    break;
                default:
                    break;
            }

            PopulateAnimalListBox();













        }

        private void PopulateAnimalListBox()
        {
            lbAnimals.Items.AddRange(animalManager.AnimalList.ToArray());
            
        }



        private Category GetSelectedCategory()
        {
            Category category = (Category)cboCategory.SelectedIndex;
            return category;
        }

        private BirdSpecies GetBirdSpecies()
        {
            BirdSpecies species = (BirdSpecies)cboSpecies.SelectedIndex;
            return species;
        }

        private MammalSpecies GetMammalSpecies()
        {
            MammalSpecies species = (MammalSpecies)cboSpecies.SelectedIndex;
            return species;
        }

























    }
}
