using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class AtvDolares
    {
        public static void Exercicio() {
            Console.Write("Qual é a cotação do Dólar: ");
            double dolar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantos doláres você vai comprar: ");
            double quant = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Coversao(dolar, quant);

            Console.WriteLine("Valor a ser pago em reais = " + valor.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
