using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class AtvFuncionario
    {
        public static void Exercicio()
        {
            Empregado empregado = new Empregado();
            Console.Write("Nome: ");
            empregado.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            empregado.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            empregado.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Empregado: " + empregado.Nome + ", R$" + empregado.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a Porcentagem p/ aumentar o Salário: ");
            empregado.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + empregado.Nome + ", R$" + empregado.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
