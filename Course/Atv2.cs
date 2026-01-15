using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    internal class Atv2
    {
        static void Lesson(string[] args)
        {
            Console.Write("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre seu ultimo nome, idade e altura(mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');

            string ult = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ult);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
