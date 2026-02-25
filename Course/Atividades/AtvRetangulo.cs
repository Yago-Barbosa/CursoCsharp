using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    public class AtvRetangulo
    {
        public static void Exercicio()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Digite a Largura e Altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
