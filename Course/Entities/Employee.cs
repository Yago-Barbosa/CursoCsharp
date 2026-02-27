using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    internal class Employee
    {
        /* Classe utilizada em aulas anteoriores
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public double Salary {  get; set; }

        //public Employee () { }
        //public Employee(int Id, string name, double salary)
        //{
        //    ID = Id;
        //    Name = name;
        //    Salary = salary;
        //}

        //public void IncreaseSalary(double percentage)
        //{
        //    Salary += Salary * (percentage / 100.0);
        //}

        //public override string ToString()
        //{
        //    return ID + ", " + Name + ", R$" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }*/

        // Classe para exercicio resolvido

        public string? Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $ " + Payment().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
