using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Data_Management_System
{
    class Person
    {
        string surname, givenName;
        double height;
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
    }
}
