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
            PopulateSexListBox();
            PopulateCategoryListBox();
            lblAnimalListHeader.Text = $"{"Id",-10} {"Name",-20} {"Age",-10} {"Sex",-15} {"Specification"}";
        }

        private void PopulateSexListBox()
        {
            string[] sexValues = Enum.GetNames(typeof(Sex));
            lbSex.Items.AddRange(sexValues);
            lbSex.SelectedIndex = (int)Sex.Other;
        }

        private void PopulateCategoryListBox()
        {
            string[] categoryValues = Enum.GetNames(typeof(Category));
            lbCategory.Items.AddRange(categoryValues);
            lbCategory.SelectedIndex = (int)Category.Mammal;
        }




        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbCategory.SelectedIndex;
            if (index > -1)
            {
                lbSpecies.Items.Clear();
                Category category = GetSelectedCategory();
                PopulateSpeciesListBox(category);
                ShowUserControl(category);



            }
        }

        private void ShowUserControl(Category category)
        {
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

        private void PopulateSpeciesListBox(Category category)
        {
            string[] speciesValues;

            switch (category)
            {
                case Category.Mammal:
                    speciesValues = Enum.GetNames(typeof(MammalSpecies));
                    lbSpecies.Items.AddRange(speciesValues);
                    lbSpecies.SelectedIndex = (int)MammalSpecies.Cat; //TODO: figure out how to remove this and deal with animal == null;



                    break;
                case Category.Bird:
                    speciesValues = Enum.GetNames(typeof(BirdSpecies));
                    lbSpecies.Items.AddRange(speciesValues);
                    lbSpecies.SelectedIndex = (int)BirdSpecies.Budgerigar;

                    break;
            }


        }






















        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (lbCategory.SelectedIndex > -1)
            {
                Category category = GetSelectedCategory();

                Animal animal;
                switch (category)
                {
                    case Category.Mammal:
                        animal = AnimalFactory.CreateMammalSpecies(GetMammalSpecies(), animalManager.AnimalId); //TODO: find a good what to check for animal != null
                        if (ReadInput(category, animal))
                        {
                            animalManager.AddAnimal(animal);
                        }
                        break;

                    case Category.Bird:
                        animal = AnimalFactory.CreateBirdSpecies(GetBirdSpecies(), animalManager.AnimalId);
                        if (ReadInput(category, animal))
                        {
                            animalManager.AddAnimal(animal);

                        }
                        break;
                }
            }
            PopulateAnimalListBox();
        }


        private bool ReadInput(Category category, Animal animal)
        {
            bool isSuccessful = false;
            bool isValidName = ReadName(animal);
            bool isValidAge = ReadAge(animal);
            bool isValidSex = ReadSex(animal);
            bool isValidSpecification = ReadSpecifications(category, animal);

            if (isValidName && isValidAge && isValidSex && isValidSpecification)
            {
                isSuccessful = true;
            }

            return isSuccessful;
        }


        private bool ReadSex(Animal animal)
        {
            bool isSuccessful = false;

            if (lbSex.SelectedIndex > -1)
            {
                animal.Sex = GetSex();
                isSuccessful = true;
            }
            return isSuccessful;
        }

        private void PopulateAnimalListBox()
        {
            lbAnimals.Items.AddRange(animalManager.AnimalList.ToArray());

        }



        private Category GetSelectedCategory()
        {


            Category category = (Category)lbCategory.SelectedIndex;
            return category;


        }

        private BirdSpecies GetBirdSpecies()
        {
            BirdSpecies species = (BirdSpecies)lbSpecies.SelectedIndex;
            return species;
        }

        private MammalSpecies GetMammalSpecies()
        {
            MammalSpecies species = (MammalSpecies)lbSpecies.SelectedIndex;
            return species;
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

        private Sex GetSex()
        {
            Sex sex = (Sex)lbSex.SelectedIndex;
            return sex;

        }

        private bool ReadSpecifications(Category category, Animal animal)
        {


            switch (category)
            {
                case Category.Mammal:
                    ReadMammalSpecifications(animal);
                    return true;
                case Category.Bird:
                    ReadBirdSpecification(animal);
                    return true;
                default:
                    return false;
            }




        }




        private bool ReadMammalSpecifications(Animal animal)
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
