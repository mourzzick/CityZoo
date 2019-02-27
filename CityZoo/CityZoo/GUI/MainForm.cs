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


        private bool ReadInput(Animal animal)
        {
            bool isSuccessful = false;
            return isSuccessful;
        }

        private bool ReadName(Animal animal)
        {
            bool isSuccessful = false;
            string name = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(name))
            {
                animal.Name = name;
                isSuccessful = true;
            }
            else
            {
                MessageBox.Show("Please add animal name.");
            }
            return isSuccessful;
        }

        private bool ReadAge(Animal animal)
        {
            bool isSuccessful = false;
            double age;
            bool isDouble = Double.TryParse(txtAge.Text.Trim(), out age);
            if (isDouble)
            {
                animal.Age = age;
                isSuccessful = true;
            }
            else
            {
                MessageBox.Show("Please add valid animal age.");
            }
            return isSuccessful;

        }


        private bool ReadMammalSpecifications (Animal animal)
        {
            bool isSuccessful = false;
            int numberOfTeeth = mammalUserControl.NumberOfTheet;
            int tailLenght = mammalUserControl.TailLength;

            if (numberOfTeeth >= 0 && tailLenght >= 0)
            {
                ((Mammal)animal).NumberOfTeeth = numberOfTeeth;
                ((Mammal)animal).TailLength = tailLenght;
                isSuccessful = true;
            }
            else
            {
                MessageBox.Show("Please add number of teeth and tail length.");
            }
            return isSuccessful;
        }

        private bool ReadBirdSpecification(Animal animal)
        {
            bool isSuccessful = false;
            int flyingSpeed = birdUserControl.FlyingSpeed;
            int wingspan = birdUserControl.Wingspan;

            if (flyingSpeed >= 0 && wingspan >= 0)
            {
                ((Bird)animal).FlyingSpeed = flyingSpeed;
                ((Bird)animal).Wingspan = wingspan;
                isSuccessful = true;

            }
            else
            {
                MessageBox.Show("Please add number of flying speed and wingspan.");

            }
            return isSuccessful;

        }





























    } // end class
}
