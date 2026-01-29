using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    internal class AtvBanco
    {
        public static void Exercicio()
        {
            double valor = 0.0;
            Console.Write("Digite o Número da Conta: ");
            string id = Console.ReadLine()!;

            Console.Write("Digite o Nome do Titular da conta: ");
            string nome = Console.ReadLine()!;

            Console.Write("Haverá Deposito Inicial (s/n)? ");
            char dp = char.Parse(Console.ReadLine()!);

            if (dp == 's'){
                Console.Write("Valor do Deposito Inicial: ");
                valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            } 
             
            ContaBancaria user = new ContaBancaria(id, nome, valor);

            Console.WriteLine();
            Console.WriteLine("---------- Dados da Conta ----------");
            Console.WriteLine(user);
            Console.WriteLine();

            Console.Write("Digite um valor para um Deposito: ");
            user.Depositar(double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(user);

            Console.WriteLine();
            Console.Write("Digite um valor para Saque: ");
            user.Saque(double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(user);
        }
    }
}
