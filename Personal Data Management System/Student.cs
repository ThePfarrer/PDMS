using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Data_Management_System
{
    class Student : Person
    {
        double matriculationNumber;
        readonly double creditPoints;

        public double MatriculationNumber { get => matriculationNumber; set => matriculationNumber = value; }

        public double CreditPoints => creditPoints;

        public Student(string surname, string givenName, double height, genderType gender, 
            eyeColorType eyeColor, double matriculationNumber, double creditPoints) : 
            base(surname, givenName, height, gender, eyeColor)
        {
            this.creditPoints = creditPoints;
            this.matriculationNumber = matriculationNumber;
        }
    }
}
