using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Data_Management_System
{
    public partial class Form1 : Form
    {
        Person[] people = new Person[5];
        int currentindex = 0;
        public Form1()
        {
            people[0] = new Person("Carroll", "Mark", 1.78, genderType.male, eyeColorType.blue);
            people[1] = new Person("Murphy", "Tatyana", 1.64, genderType.female, eyeColorType.gray);
            people[2] = new Person("Bartell", "Jack", 1.34, genderType.male, eyeColorType.brown);
            people[3] = new Person("Franecki", "Jerrell", 1.74, genderType.male, eyeColorType.green);
            people[4] = new Person("Hagenes", "Frieda", 1.54, genderType.female, eyeColorType.brown);
            InitializeComponent();
            
        }

        void RefreshGuiData()
        {
            textBoxSurName.Text = people[currentindex].Surname;
            textBoxGivenName.Text = people[currentindex].GivenName;
            textBoxHeight.Text = people[currentindex].Height.ToString();
            comboBoxEyeColor.DataSource = Enum.GetValues(typeof(eyeColorType));
            comboBoxGender.DataSource = Enum.GetValues(typeof(genderType));
            comboBoxGender.SelectedItem = people[currentindex].Gender;
            comboBoxEyeColor.SelectedItem = people[currentindex].EyeColor;
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGuiData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentindex > 0)
            {
                currentindex--;
                RefreshGuiData();
            }
            else
            {
                currentindex = 0;
                RefreshGuiData();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (currentindex < 5)
            {
                currentindex++;
                RefreshGuiData();
            }
            else
            {
                currentindex = 4;
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

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
