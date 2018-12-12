using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Personal_Data_Management_System
{
    [Serializable]

    [XmlInclude(typeof(Person))]
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Employee))]

    public class Person
    {
        protected string surName;
        protected string givenName;
        protected double height;
        genderType gender;
        eyeColorType eyeColor;

        public Person()
        {

        }

        public Person(string surname, string givenName, double height, genderType gender, eyeColorType eyeColor)
        {
            this.surName = surname;
            this.givenName = givenName;
            this.height = height;
            this.gender = gender;
            this.eyeColor = eyeColor;
        }

        public string SurName { get => surName; set => surName = value; }
      
        public double Height { get => height; set => height = value; }
        public string GivenName { get => givenName; set => givenName = value; }
        public genderType Gender { get => gender; set => gender = value; }
        public eyeColorType EyeColor { get => eyeColor; set => eyeColor = value; }
    }
}
