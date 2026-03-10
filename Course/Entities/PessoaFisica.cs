using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Course.Entities
{
    internal class PessoaFisica : Contribuinte
    {
        public double HealthExpenditure { get; set; }

        public PessoaFisica(double healthExpenditure, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            if(AnualIncome <= 20000.00)
            {
                if(HealthExpenditure > 0)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditure * 0.5);
                }
                else
                {
                    return AnualIncome * 0.15;
                }
            } else
            {
                if (HealthExpenditure > 0)
                {
                    return (AnualIncome * 0.25) - (HealthExpenditure * 0.5);
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}
