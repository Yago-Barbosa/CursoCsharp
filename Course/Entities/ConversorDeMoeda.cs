using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    public class ConversorDeMoeda
    {
        public static double Coversao(double Dolar, double Quant) {
            return (Dolar * Quant) * 1.06;
        }
    }
}
