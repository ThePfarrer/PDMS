using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Data_Management_System
{
    [Serializable]
    public class Employee : Person
    {
        double employeeNumber;
        readonly double salary;

        public double EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }

        public double Salary => salary;

        public Employee()
        {

        }

        public Employee(string surname, string givenName, double height, genderType gender, eyeColorType eyeColor,
            double employeeNumber, double salary) : base(surname, givenName, height, gender, eyeColor)
        {
            this.employeeNumber = employeeNumber;
            this.salary = salary;
        }
    }
}
