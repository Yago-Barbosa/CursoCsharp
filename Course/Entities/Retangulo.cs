using System;
using System.Globalization;

namespace Course.Entities
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
           return Largura * Altura;
        }
        public double Perimetro()
        {
            return Largura + Largura + Altura + Altura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
