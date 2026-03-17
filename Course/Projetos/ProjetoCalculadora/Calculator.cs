using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Projetos.ProjetoCalculadora
{
    internal class Calculator
    {
        public int Operator { get; set; }

        public Calculator(int operate)
        {
            Operator = operate;
        }

        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("Erro ao dividir por zero");
          
            return n1 / n2;
        }
    }
}
