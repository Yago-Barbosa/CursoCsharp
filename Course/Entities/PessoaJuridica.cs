using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumberOfEmployees { get; set; }
        
        public PessoaJuridica(int numberOfEmployess, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployess;
        }

        public override double Tax()
        {
            if(NumberOfEmployees <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
