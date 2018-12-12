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
using System.Xml.Serialization;

namespace Personal_Data_Management_System
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        int currentindex = 0;
        public Form1()
        {
            InitializeComponent();

            people.Add(new Person("Carroll", "Mark", 1.78, genderType.male, eyeColorType.blue));
            people.Add(new Person("Murphy", "Tatyana", 1.64, genderType.female, eyeColorType.gray));
            people.Add(new Person("Bartell", "Jack", 1.34, genderType.male, eyeColorType.brown));
            people.Add(new Person("Franecki", "Jerrell", 1.74, genderType.male, eyeColorType.green));
            people.Add(new Employee("James", "Milner", 1.67, genderType.male, eyeColorType.brown, 16454, 240050));
            people.Add(new Student("Hagenes", "Frieda", 1.54, genderType.female, eyeColorType.brown, 12456, 5.0));

            comboBoxEyeColor.DataSource = Enum.GetValues(typeof(eyeColorType));
            comboBoxGender.DataSource = Enum.GetValues(typeof(genderType));

        }

        void RefreshGuiData()
        {
            textBoxSurName.Text = people[currentindex].SurName;
            textBoxGivenName.Text = people[currentindex].GivenName;
            textBoxHeight.Text = people[currentindex].Height.ToString();
            comboBoxGender.SelectedItem = people[currentindex].Gender;
            comboBoxEyeColor.SelectedItem = people[currentindex].EyeColor;
            textBoxMatriculationNo.Hide();
            CPOutputLabel.Hide();
            textBoxEmployeeNo.Hide();
            salaryOutputLabel.Hide();
            maleLabelOutput.Text = people.Count(p => p.Gender == genderType.male).ToString();
            femaleOutputLabel.Text = people.Count(p => p.Gender == genderType.female).ToString();
            brownEyedOutputLabel.Text = people.Count(p => p.EyeColor == eyeColorType.brown).ToString();
            tallestOutputLabel.Text = people.Max(p => p.Height).ToString();
            shortestOutputLabel.Text = people.Min(p => p.Height).ToString();
            averageOutputLabel.Text = Math.Round(people.Average(p => p.Height), 2).ToString();

            if (people[currentindex] is Student s)
            {
                textBoxMatriculationNo.Show();
                CPOutputLabel.Show();
                textBoxMatriculationNo.Text = s.MatriculationNumber.ToString();
                CPOutputLabel.Text = s.CreditPoints.ToString();
                
            }
            if (people[currentindex] is Employee e)
            {
                textBoxEmployeeNo.Show();
                salaryOutputLabel.Show();
                textBoxEmployeeNo.Text = e.EmployeeNumber.ToString();
                salaryOutputLabel.Text = e.Salary.ToString();
            }
            
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
            if (currentindex < people.Count - 1)
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
            people[currentindex].SurName = textBoxSurName.Text;
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
            ((Student)people[currentindex]).MatriculationNumber = Convert.ToDouble(textBoxMatriculationNo.Text);
        }

        private void textBoxEmployeeNo_TextChanged(object sender, EventArgs e)
        {
            ((Employee)people[currentindex]).EmployeeNumber = Convert.ToDouble(textBoxEmployeeNo.Text);
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
                people = (List<Person>)formatter.Deserialize(str);
                str.Close();
            }
            RefreshGuiData();
        }

        private void saveXMLButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream str = new FileStream(saveFileDialog.FileName, FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                xmlSerializer.Serialize(str, people);
                str.Close();
            }
        }

        private void loadXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream str = new FileStream(openFileDialog.FileName, FileMode.Open);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                people = (List<Person>)xmlSerializer.Deserialize(str);
                str.Close();
            }
            RefreshGuiData();
        }

        private void promoteToStudent_Click(object sender, EventArgs e)
        {
            if (!((people[currentindex] is Student) || (people[currentindex] is Employee)))
            {
                people[currentindex] = new Student(people[currentindex].SurName, people[currentindex].GivenName, people[currentindex].Height,
                    people[currentindex].Gender, people[currentindex].EyeColor, 0000, 0);
            }
            RefreshGuiData();
        }

        private void promoteToEmployee_Click(object sender, EventArgs e)
        {
            if (!(people[currentindex] is Employee))
            { 
                people[currentindex] = new Employee(people[currentindex].SurName, people[currentindex].GivenName, people[currentindex].Height,
                    people[currentindex].Gender, people[currentindex].EyeColor, 0000, 1500);
            }
            RefreshGuiData();
        }

        private void sortSurnameButton_Click(object sender, EventArgs e)
        {
            people = people.OrderBy(p => p.SurName).ToList();
            RefreshGuiData();
        }

        private void sortGivenNameButton_Click(object sender, EventArgs e)
        {
            people = people.OrderBy(p => p.GivenName).ToList();
            RefreshGuiData();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            List<string> names = people.OrderBy(p => p.SurName)
                    .Where(p => (p.Gender == genderType.female) && (p.EyeColor == eyeColorType.blue) && (p.Height >= 1.7) && (p.Height <= 1.71))
                    .Select(p => p.SurName)
                    .ToList();
            
            string s = "";
            foreach (string n in names)
            {
                s += n + Environment.NewLine;
            }

            filterTextbox.Text = s;
        }
    }
}
