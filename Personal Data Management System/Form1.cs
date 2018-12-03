using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Data_Management_System
{
    public partial class Form1 : Form
    {
        Person[] people = new Person[6];
        int currentindex = 0;
        public Form1()
        {
            InitializeComponent();

            people[0] = new Person("Carroll", "Mark", 1.78, genderType.male, eyeColorType.blue);
            people[1] = new Person("Murphy", "Tatyana", 1.64, genderType.female, eyeColorType.gray);
            people[2] = new Person("Bartell", "Jack", 1.34, genderType.male, eyeColorType.brown);
            people[3] = new Person("Franecki", "Jerrell", 1.74, genderType.male, eyeColorType.green);
            people[4] = new Person("Hagenes", "Frieda", 1.54, genderType.female, eyeColorType.brown);
            people[5] = new Student("Hagenes", "Frieda", 1.54, genderType.female, eyeColorType.brown, 12456, 5.0);

            comboBoxEyeColor.DataSource = Enum.GetValues(typeof(eyeColorType));
            comboBoxGender.DataSource = Enum.GetValues(typeof(genderType));

        }

        void RefreshGuiData()
        {
            textBoxSurName.Text = people[currentindex].Surname;
            textBoxGivenName.Text = people[currentindex].GivenName;
            textBoxHeight.Text = people[currentindex].Height.ToString();
            comboBoxGender.SelectedItem = people[currentindex].Gender;
            comboBoxEyeColor.SelectedItem = people[currentindex].EyeColor;
            //CPOutputLabel.Text = ((Student)people[currentindex]).CreditPoints.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGuiData();
        }

        
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentindex > 0)
            {
                currentindex--;
                RefreshGuiData();
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentindex < 4)
            {
                currentindex++;
                RefreshGuiData();
            }
            
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            people[currentindex].Gender = (genderType)comboBoxGender.SelectedItem;
    }

        private void comboBoxEyeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            people[currentindex].EyeColor = (eyeColorType)comboBoxEyeColor.SelectedItem;
        }

        private void textBoxSurName_TextChanged(object sender, EventArgs e)
        {
            people[currentindex].Surname = textBoxSurName.Text;
        }

        private void textBoxGivenName_TextChanged(object sender, EventArgs e)
        {
            people[currentindex].GivenName = textBoxGivenName.Text;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            people[currentindex].Height = Convert.ToDouble(textBoxHeight.Text);
        }

        private void textBoxMatriculationNo_TextChanged(object sender, EventArgs e)
        {
            //people[currentindex]. = Convert.ToDouble(textBoxHeight.Text);
        }

        private void textBoxEmployeeNo_TextChanged(object sender, EventArgs e)
        {
            //people[currentindex].Height = Convert.ToDouble(textBoxHeight.Text);
        }

        private void saveBinButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream str = new FileStream(saveFileDialog.FileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(str, people);
                str.Close();
            }

        }

        private void loadBinButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "binary files (*.bin)|*.bin|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream str = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                people = (Person[])formatter.Deserialize(str);
                str.Close();
            }
            RefreshGuiData();
        }
    }
}
