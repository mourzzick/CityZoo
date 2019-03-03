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

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            animalManager = new AnimalManager();
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes all MainForm controls to their default state.
        /// </summary>
        private void InitializeGUI()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            PopulateSexListBox();
            PopulateCategoryListBox();
            lblAnimalListHeader.Text = $"{"Id",-10} {"Name",-20} {"Age",-10} {"Sex",-15} {"Specification"}";
        }

        /// <summary>
        /// Adds all available values to the sex list-box.
        /// </summary>
        private void PopulateSexListBox()
        {
            string[] sexValues = Enum.GetNames(typeof(Sex));
            lbSex.Items.AddRange(sexValues);
            lbSex.SelectedIndex = (int)Sex.Other;
        }

        /// <summary>
        /// Adds all available values to the category list-box.
        /// </summary>
        private void PopulateCategoryListBox()
        {
            string[] categoryValues = Enum.GetNames(typeof(Category));
            lbCategory.Items.AddRange(categoryValues);
            lbCategory.SelectedIndex = (int)Category.Mammal;
        }

        /// <summary>
        /// Displays appropriate user control input and adds all values to the species
        /// list-box based on the selected animal category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Adds all available values to the category list-box based on the animal category.
        /// </summary>
        /// <param name="category"></param>
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

        /// <summary>
        /// Displays appropriate user control based on animal category.
        /// </summary>
        /// <param name="category"></param>
        private void ShowUserControl(Category category)
        {
            switch (category)
            {
                case Category.Mammal:
                    birdUserControl.Hide();
                    birdUserControl.Clear();
                    mammalUserControl.Show();
                    break;

                case Category.Bird:
                    mammalUserControl.Hide();
                    mammalUserControl.Clear();
                    birdUserControl.Show();
                    break;
            }
        }

        /// <summary>
        /// Reads all input controls and adds a new animal to the animal manager.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            lbAnimals.Items.Clear();
            PopulateAnimalListBox();
        }
     
        /// <summary>
        /// Gets the selected animal category.
        /// </summary>
        /// <returns></returns>
        private Category GetSelectedCategory()
        {
            Category category = (Category)lbCategory.SelectedIndex;
            return category;
        }

        /// <summary>
        /// Gets the selected mammal species.
        /// </summary>
        /// <returns></returns>
        private MammalSpecies GetMammalSpecies()
        {
            MammalSpecies species = (MammalSpecies)lbSpecies.SelectedIndex;
            return species;
        }

        /// <summary>
        /// Gets the selected bird species.
        /// </summary>
        /// <returns></returns>
        private BirdSpecies GetBirdSpecies()
        {
            BirdSpecies species = (BirdSpecies)lbSpecies.SelectedIndex;
            return species;
        }

        /// <summary>
        /// Reads all input controls.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads the name input control.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads the age input control.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads the sex input control
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        private bool ReadSex(Animal animal)
        {
            bool isSuccessful = false;

            if (lbSex.SelectedIndex > -1)
            {
                animal.Sex = (Sex)lbSex.SelectedIndex;
                isSuccessful = true;
            }
            return isSuccessful;
        }

        /// <summary>
        /// Adds all animal records form the animal manager to the animal list-box.
        /// </summary>
        private void PopulateAnimalListBox()
        {
            lbAnimals.Items.AddRange(animalManager.AnimalList.ToArray());
        }

        /// <summary>
        /// Reads the animal specification information based on the selected category
        /// </summary>
        /// <param name="category"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        private bool ReadSpecifications(Category category, Animal animal)
        {
            switch (category)
            {
                case Category.Mammal:
                    return ReadMammalSpecifications(animal);
                case Category.Bird:
                    return ReadBirdSpecification(animal);
                default:
                    return false;
            }
        }

        /// <summary>
        /// Reads the mammal user control input
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        private bool ReadMammalSpecifications(Animal animal)
        {
            bool isSuccessful = false;
            int numberOfTeeth = mammalUserControl.NumberOfTheet;
            int tailLenght = mammalUserControl.TailLength;

            if (numberOfTeeth > -1 && tailLenght > -1)
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

        /// <summary>
        /// Reads the bird user control input
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        private bool ReadBirdSpecification(Animal animal)
        {
            bool isSuccessful = false;
            int flyingSpeed = birdUserControl.FlyingSpeed;
            int wingspan = birdUserControl.Wingspan;

            if (flyingSpeed > -1 && wingspan > -1)
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
