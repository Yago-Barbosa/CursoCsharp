using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    public class Atv4
    {
        public static void Exercicio()
        {
            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("---------- Dados do Primeiro Funcionario ----------");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("---------- Dados do Segundo Funcionario ----------");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double medio = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salário Médio: " + medio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
