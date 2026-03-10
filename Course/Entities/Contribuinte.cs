using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal abstract class Contribuinte
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contribuinte(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
