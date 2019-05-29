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
            HideUserControls();
            ClearInput();
            PopulateSexListBox();
            PopulateCategoryListBox();
            chbListAllAnimals.Checked = false;
            lblAnimalListHeader.Text = $"{"Id",-7}{"Name",-18}{"Age",-7}{"Sex",-10} {"Specification"}";
        }

        /// <summary>
        /// Hides all user controls
        /// </summary>
        private void HideUserControls()
        {
            mammalUserControl.Hide();
            birdUserControl.Hide();
            budgerigarUserControl.Hide();
            catUserControl.Hide();
            dogUserControl.Hide();
            eagleUserControl.Hide();
        }

        /// <summary>
        /// Clears all input controls
        /// </summary>
        private void ClearInput()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            birdUserControl.Clear();
            budgerigarUserControl.Clear();
            catUserControl.Clear();
            dogUserControl.Clear();
            eagleUserControl.Clear();
            mammalUserControl.Clear();
        }

        /// <summary>
        /// Adds all available values to the sex list-box.
        /// </summary>
        private void PopulateSexListBox()
        {
            string[] sexValues = Enum.GetNames(typeof(Sex));
            lbSex.Items.AddRange(sexValues);
            lbSex.SelectedIndex = 0;
        }

        /// <summary>
        /// Adds all available values to the category list-box.
        /// </summary>
        private void PopulateCategoryListBox()
        {
            string[] categoryValues = Enum.GetNames(typeof(Category));
            lbCategory.Items.AddRange(categoryValues);
            lbCategory.SelectedIndex = 0;
        }

        /// <summary>
        /// Adds appropriate species to the species list-box on category list-box index change.
        /// </summary>
        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSpeciesListBox();
        }

        /// <summary>
        /// Updates the species list-box bases on selected category.
        /// </summary>
        private void UpdateSpeciesListBox()
        {
            int index = lbCategory.SelectedIndex;
            if (index > -1)
            {
                ClearInput();
                lbSpecies.Items.Clear();
                Category category = GetSelectedCategory();
                PopulateSpeciesListBox(category);
            }
        }

        /// <summary>
        /// Shows all species in the species list-box and disables the category list-box
        /// </summary>
        // TODO: Implement this method correctly 
        //private void chbListAllAnimals_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chbListAllAnimals.Checked)
        //    {
        //        lbCategory.Enabled = false;
        //        PopulateAllSpeciesListBox();
        //    }
        //    else
        //    {
        //        lbCategory.Enabled = true;
        //        UpdateSpeciesListBox();
        //    }
        //}

        /// <summary>
        /// Adds all available values to the category list-box based on the animal category.
        /// </summary>
        private void PopulateSpeciesListBox(Category category)
        {
            string[] speciesValues;

            switch (category)
            {
                case Category.Mammal:
                    gbAnimalSpecification.Text = "Mammal specification"; //TODO: might be better to create UpdateGUI method.
                    speciesValues = Enum.GetNames(typeof(MammalSpecies));
                    lbSpecies.Items.AddRange(speciesValues);
                    lbSpecies.SelectedIndex = 0; //TODO: I don't like having default value but it prevents animal == null later on.
                    break;
                case Category.Bird:
                    gbAnimalSpecification.Text = "Bird specification"; //TODO: might be better to create UpdateGUI method.
                    speciesValues = Enum.GetNames(typeof(BirdSpecies));
                    lbSpecies.Items.AddRange(speciesValues);
                    lbSpecies.SelectedIndex = 0;
                    break;
            }
        }

        /// <summary>
        /// Displays appropriate species user controls bases on selected species
        /// </summary>
        private void lbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbSpecies.SelectedIndex;
            if (index > -1)
            {
                ClearInput();
                string species = lbSpecies.Text;
                ShowUserControls(species);
            }
        }

        // TODO: I don't like that the methods user string as a parameter, perhaps AllSpecies enum? 
        /// <summary>
        /// Displays appropriate user control based on animal species.
        /// </summary>
        private void ShowUserControls(string species)
        {
            HideUserControls();

            switch (species)
            {
                case "Budgerigar":
                    birdUserControl.Show();
                    budgerigarUserControl.Show();
                    break;
                case "Cat":
                    mammalUserControl.Show();
                    catUserControl.Show();
                    break;
                case "Dog":
                    mammalUserControl.Show();
                    dogUserControl.Show();
                    break;
                case "Eagle":
                    birdUserControl.Show();
                    eagleUserControl.Show();
                    break;
            }
        }

        /// <summary>
        /// Reads all input controls and adds a new animal to the animal manager.
        /// </summary>
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (lbCategory.SelectedIndex > -1 && IsValidUserInput())
            {
                Animal animal;
                Category category = GetSelectedCategory();
                UserInput userInput = new UserInput();
                ReadUserInput(userInput);

                switch (category)
                {
                    case Category.Mammal:
                        animal = AnimalFactory.CreateMammalSpecies(GetMammalSpecies(), userInput);
                        animalManager.Add(animal);
                        break;
                    case Category.Bird:
                        animal = AnimalFactory.CreateBirdSpecies(GetBirdSpecies(), userInput);
                        animalManager.Add(animal);
                        break;
                }
            }
            lbAnimals.Items.Clear();
            PopulateAnimalListBox();
        }

        /// <summary>
        /// Reads all user input controls
        /// </summary>
        private void ReadUserInput(UserInput userInput)
        {
            userInput.Name = ReadName();
            userInput.Age = ReadAge();
            userInput.Sex = ReadSex();
            userInput.NumberOfTeeth = ReadNumberOfTeeth();
            userInput.FlyingSpeed = ReadFlyingSpeed();
            userInput.TailLength = ReadTailLength();
            userInput.Breed = ReadBreed();
            userInput.Color = ReadColor();
            userInput.Wingspan = ReadWingspan();
        }

        /// <summary>
        /// Adds all animal records form the animal manager to the animal list-box.
        /// </summary>
        private void PopulateAnimalListBox()
        {
            lbAnimals.Items.AddRange(animalManager.ToStringArray());
        }


        /// <summary>
        /// Reads the name input control
        /// </summary>
        private string ReadName()
        {
            return txtName.Text.Trim();
        }

        /// <summary>
        /// Reads the age input control
        /// </summary>
        private double ReadAge()
        {
            double age;
            bool isSuccessful = double.TryParse(txtAge.Text.Trim(), out age);
            if (isSuccessful)
            {
                return age;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Reads the sex input control
        /// </summary>
        private Sex ReadSex()
        {
            return (Sex)lbSex.SelectedIndex;
        }

        /// <summary>
        /// Reads the number of teeth input control
        /// </summary>
        private int ReadNumberOfTeeth()
        {
            return mammalUserControl.NumberOfTheet;
        }

        /// <summary>
        /// Reads the flying speed input control
        /// </summary>
        private int ReadFlyingSpeed()
        {
            return birdUserControl.FlyingSpeed;
        }

        /// <summary>
        /// Reads the tail length input control
        /// </summary>
        private int ReadTailLength()
        {
            return catUserControl.TailLength;
        }

        /// <summary>
        /// Reads the breed input control
        /// </summary>
        private string ReadBreed()
        {
            return dogUserControl.Breed;
        }

        /// <summary>
        /// Reads the color input control
        /// </summary>
        private string ReadColor()
        {
            return budgerigarUserControl.Color;
        }

        /// <summary>
        /// Reads the number wingspan input control
        /// </summary>
        private int ReadWingspan()
        {
            return eagleUserControl.Wingspan;
        }

        // TODO: This validation method turned into spaghetti. It will be good to come up with
        // something different. https://www.youtube.com/watch?v=akj8W1QvbGI
        /// <summary>
        /// Validates all but sex user input
        /// </summary>
        private bool IsValidUserInput()
        {
            bool isValidName = !string.IsNullOrEmpty(ReadName());
            if (!isValidName)
            {
                MessageBox.Show("Please enter a valid name.");
            }
            bool isVlaidAge = (ReadAge() > 0);
            if (!isVlaidAge)
            {
                MessageBox.Show("Please enter a valid age.");
            }

            bool isVlaidNumberOfTeeth = true;
            if (mammalUserControl.Visible && ReadNumberOfTeeth() < 0)
            {
                isVlaidNumberOfTeeth = false;
                MessageBox.Show("Please enter valid number of teeth.");
            }
            bool isVlaidFlyingSpeed = true;
            if (birdUserControl.Visible && ReadFlyingSpeed() < 0)
            {
                isVlaidFlyingSpeed = false;
                MessageBox.Show("Please enter valid flying speed.");
            }
            bool isValidTailLength = true;
            if (catUserControl.Visible && ReadTailLength() < 0)
            {
                isValidTailLength = false;
                MessageBox.Show("Please enter valid tail length.");
            }
            bool isValidBreed = true;
            if (dogUserControl.Visible && string.IsNullOrEmpty(ReadBreed()))
            {
                isValidBreed = false;
                MessageBox.Show("Please enter valid breed.");
            }
            bool isValidColor = true;
            if (budgerigarUserControl.Visible && string.IsNullOrEmpty(ReadColor()))
            {
                isValidColor = false;
                MessageBox.Show("Please enter valid color.");
            }
            bool isValidWingspan = true;
            if (eagleUserControl.Visible && ReadWingspan() < 0)
            {
                isValidWingspan = false;
                MessageBox.Show("Please enter valid wingspan.");
            }

            return isValidName && isVlaidAge && isVlaidNumberOfTeeth && isVlaidFlyingSpeed &&
                isValidTailLength && isValidBreed && isValidColor && isValidWingspan;
        }

        /// <summary>
        /// Gets the selected animal category.
        /// </summary>
        private Category GetSelectedCategory()
        {
            Category category = (Category)lbCategory.SelectedIndex;
            return category;
        }

        /// <summary>
        /// Gets the selected mammal species.
        /// </summary>
        private MammalSpecies GetMammalSpecies()
        {
            MammalSpecies species = (MammalSpecies)lbSpecies.SelectedIndex;
            return species;
        }

        /// <summary>
        /// Gets the selected bird species.
        /// </summary>
        private BirdSpecies GetBirdSpecies()
        {
            BirdSpecies species = (BirdSpecies)lbSpecies.SelectedIndex;
            return species;
        }

        private void lbAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbAnimals.SelectedIndex;
            if (index > -1)
            {
                Animal animal = animalManager.GetAt(index);
                txtEaterType.Text = animal.GetEaterType().ToString();
                txtFoodSchedule.Text = (animal.GetFoodSchedule().ToString());

            }
        }

        /// <summary>
        /// Adds animal image to the animalImage picture-box
        /// </summary>
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAnimalImage.Image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {

            int index = lbAnimals.SelectedIndex;
            if (index > -1)
            {
                bool isDeleted = animalManager.DeleteAt(index);
                if (isDeleted)
                {
                    lbAnimals.Items.Clear();
                    PopulateAnimalListBox();
                }
            }
        }

        // TODO: implement the method when fixing the check-box feature.
        //private void PopulateAllSpeciesListBox()
        //{
        //    lbSpecies.Items.Clear();
        //    lbSpecies.Items.AddRange(GetAllSpecies());
        //}

        /// <summary>
        /// Gets all animal species
        /// </summary>
        // TODO: implement the method when fixing the check-box feature.
        //private string[] GetAllSpecies()
        //{
        //    List<string> speciesValues = new List<string>();
        //    speciesValues.AddRange(Enum.GetNames(typeof(MammalSpecies)).ToList());
        //    speciesValues.AddRange(Enum.GetNames(typeof(BirdSpecies)).ToList());
        //    return speciesValues.ToArray();
        //}


    } // end class
}
