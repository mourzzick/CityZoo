namespace CityZoo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.gbAnimalSpecification = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lbSpecies = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.lbSex = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAnimalListHeader = new System.Windows.Forms.Label();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEaterType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodSchedule = new System.Windows.Forms.TextBox();
            this.mammalUserControl = new CityZoo.GUI.MammalUserControl();
            this.birdUserControl = new CityZoo.GUI.BirdUserControl();
            this.catUserControl = new CityZoo.UserInterface.CatUserControl();
            this.budgerigarUserControl = new CityZoo.Models.Species.BudgerigarUserControl();
            this.eagleUserControl = new CityZoo.UserInterface.EagleUserControl();
            this.dogUserControl = new CityZoo.UserInterface.DogUserControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbAnimalSpecification.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.btnAddImage);
            this.groupBox1.Controls.Add(this.gbAnimalSpecification);
            this.groupBox1.Controls.Add(this.btnAddAnimal);
            this.groupBox1.Controls.Add(this.lbSpecies);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.lbSex);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal Specifications";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(704, 100);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(210, 210);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.Location = new System.Drawing.Point(704, 60);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(210, 30);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // gbAnimalSpecification
            // 
            this.gbAnimalSpecification.Controls.Add(this.mammalUserControl);
            this.gbAnimalSpecification.Controls.Add(this.birdUserControl);
            this.gbAnimalSpecification.Controls.Add(this.catUserControl);
            this.gbAnimalSpecification.Controls.Add(this.budgerigarUserControl);
            this.gbAnimalSpecification.Controls.Add(this.eagleUserControl);
            this.gbAnimalSpecification.Controls.Add(this.dogUserControl);
            this.gbAnimalSpecification.Location = new System.Drawing.Point(90, 243);
            this.gbAnimalSpecification.Name = "gbAnimalSpecification";
            this.gbAnimalSpecification.Size = new System.Drawing.Size(369, 164);
            this.gbAnimalSpecification.TabIndex = 11;
            this.gbAnimalSpecification.TabStop = false;
            this.gbAnimalSpecification.Text = "gbAnimalSpecification";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(478, 377);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(210, 30);
            this.btnAddAnimal.TabIndex = 10;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // lbSpecies
            // 
            this.lbSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecies.FormattingEnabled = true;
            this.lbSpecies.ItemHeight = 20;
            this.lbSpecies.Location = new System.Drawing.Point(478, 60);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(210, 304);
            this.lbSpecies.TabIndex = 9;
            this.lbSpecies.SelectedIndexChanged += new System.EventHandler(this.lbSpecies_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 20;
            this.lbCategory.Location = new System.Drawing.Point(257, 60);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(202, 164);
            this.lbCategory.TabIndex = 8;
            this.lbCategory.SelectedIndexChanged += new System.EventHandler(this.lbCategory_SelectedIndexChanged);
            // 
            // lbSex
            // 
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.FormattingEnabled = true;
            this.lbSex.ItemHeight = 20;
            this.lbSex.Location = new System.Drawing.Point(90, 140);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(145, 84);
            this.lbSex.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Animal Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Animal Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(90, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(145, 26);
            this.txtAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(90, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAnimalListHeader);
            this.groupBox3.Controls.Add(this.lbAnimals);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1412, 322);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Registered Animals";
            // 
            // lblAnimalListHeader
            // 
            this.lblAnimalListHeader.AutoSize = true;
            this.lblAnimalListHeader.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalListHeader.Location = new System.Drawing.Point(14, 30);
            this.lblAnimalListHeader.Name = "lblAnimalListHeader";
            this.lblAnimalListHeader.Size = new System.Drawing.Size(27, 19);
            this.lblAnimalListHeader.TabIndex = 1;
            this.lblAnimalListHeader.Text = "ID";
            // 
            // lbAnimals
            // 
            this.lbAnimals.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.HorizontalScrollbar = true;
            this.lbAnimals.ItemHeight = 19;
            this.lbAnimals.Location = new System.Drawing.Point(14, 51);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(1392, 232);
            this.lbAnimals.TabIndex = 0;
            this.lbAnimals.SelectedIndexChanged += new System.EventHandler(this.lbAnimals_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFoodSchedule);
            this.groupBox2.Controls.Add(this.txtEaterType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(957, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 429);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feeding Schedule";
            // 
            // txtEaterType
            // 
            this.txtEaterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEaterType.Location = new System.Drawing.Point(185, 60);
            this.txtEaterType.Name = "txtEaterType";
            this.txtEaterType.ReadOnly = true;
            this.txtEaterType.Size = new System.Drawing.Size(276, 26);
            this.txtEaterType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Eater Type";
            // 
            // txtFoodSchedule
            // 
            this.txtFoodSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodSchedule.Location = new System.Drawing.Point(10, 100);
            this.txtFoodSchedule.Multiline = true;
            this.txtFoodSchedule.Name = "txtFoodSchedule";
            this.txtFoodSchedule.ReadOnly = true;
            this.txtFoodSchedule.Size = new System.Drawing.Size(451, 264);
            this.txtFoodSchedule.TabIndex = 2;
            // 
            // mammalUserControl
            // 
            this.mammalUserControl.Location = new System.Drawing.Point(6, 22);
            this.mammalUserControl.Name = "mammalUserControl";
            this.mammalUserControl.Size = new System.Drawing.Size(334, 51);
            this.mammalUserControl.TabIndex = 0;
            // 
            // birdUserControl
            // 
            this.birdUserControl.Location = new System.Drawing.Point(6, 22);
            this.birdUserControl.Name = "birdUserControl";
            this.birdUserControl.Size = new System.Drawing.Size(334, 51);
            this.birdUserControl.TabIndex = 1;
            // 
            // catUserControl
            // 
            this.catUserControl.Location = new System.Drawing.Point(6, 79);
            this.catUserControl.Name = "catUserControl";
            this.catUserControl.Size = new System.Drawing.Size(334, 51);
            this.catUserControl.TabIndex = 3;
            // 
            // budgerigarUserControl
            // 
            this.budgerigarUserControl.Location = new System.Drawing.Point(6, 79);
            this.budgerigarUserControl.Name = "budgerigarUserControl";
            this.budgerigarUserControl.Size = new System.Drawing.Size(334, 51);
            this.budgerigarUserControl.TabIndex = 2;
            // 
            // eagleUserControl
            // 
            this.eagleUserControl.Location = new System.Drawing.Point(6, 79);
            this.eagleUserControl.Name = "eagleUserControl";
            this.eagleUserControl.Size = new System.Drawing.Size(334, 51);
            this.eagleUserControl.TabIndex = 5;
            // 
            // dogUserControl
            // 
            this.dogUserControl.Location = new System.Drawing.Point(6, 79);
            this.dogUserControl.Name = "dogUserControl";
            this.dogUserControl.Size = new System.Drawing.Size(334, 51);
            this.dogUserControl.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(704, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 795);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbAnimalSpecification.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSpecies;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.ListBox lbSex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Label lblAnimalListHeader;
        private System.Windows.Forms.GroupBox gbAnimalSpecification;
        private GUI.MammalUserControl mammalUserControl;
        private GUI.BirdUserControl birdUserControl;
        private UserInterface.CatUserControl catUserControl;
        private Models.Species.BudgerigarUserControl budgerigarUserControl;
        private UserInterface.EagleUserControl eagleUserControl;
        private UserInterface.DogUserControl dogUserControl;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEaterType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodSchedule;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

