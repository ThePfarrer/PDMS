using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Data_Management_System
{
    [Serializable]
    public class Person
    {
        protected string surname;
        protected string givenName;
        protected double height;
        genderType gender;
        eyeColorType eyeColor;

        public Person(string surname, string givenName, double height, genderType gender, eyeColorType eyeColor)
        {
            this.surname = surname;
            this.givenName = givenName;
            this.height = height;
            this.gender = gender;
            this.eyeColor = eyeColor;
        }

        public string Surname { get => surname; set => surname = value; }
      
        public double Height { get => height; set => height = value; }
        public string GivenName { get => givenName; set => givenName = value; }
        public genderType Gender { get => gender; set => gender = value; }
        public eyeColorType EyeColor { get => eyeColor; set => eyeColor = value; }
    }
}
