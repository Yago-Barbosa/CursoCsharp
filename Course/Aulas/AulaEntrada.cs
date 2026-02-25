using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Aulas
{
    internal class AulaEntrada
    {
        static void Part1(string[] args)
        {
            // Console.ReadLine(); Lê da entrada até a quebra de linha e retorna String
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            // Split ( Divide o String em partes )
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            // ele vai recortar a cada espaço(ex: "batata tomate abacaxi")
            // 0 "batata", 1 "tomate", 2 "abacaxi"
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
        static void Part2(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}