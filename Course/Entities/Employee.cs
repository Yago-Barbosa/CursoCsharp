using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary {  get; set; }

        public Employee () { }
        public Employee(int Id, string name, double salary)
        {
            ID = Id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100.0);
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", R$" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
