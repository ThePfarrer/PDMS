using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Data_Management_System
{
    class Employee : Person
    {
        double employeeNumber;
        readonly double salary;

        public Employee(string surname, string givenName, double height, genderType gender, eyeColorType eyeColor) : base(surname, givenName, height, gender, eyeColor)
        {
        }
    }
}
