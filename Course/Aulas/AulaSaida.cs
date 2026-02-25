using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Aulas
{
    internal class AulaSaida
    {
        static void Test(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.244932;
            string nome = "Yago";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));// Limite de duas casas decimais, podendo arredondar
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
        }
    }
}
