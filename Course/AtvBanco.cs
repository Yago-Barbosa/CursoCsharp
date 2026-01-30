using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    internal class AtvBanco
    {
        public static void Correcao()
        {
            ContaBancariaCorrecao conta;
            Console.Write("Digite o Número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine()!;
            Console.Write("Haverá deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine()!);

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Digite o Valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()! , CultureInfo.InvariantCulture);
                conta = new ContaBancariaCorrecao(numero, titular, depositoInicial);
            } else
            {
                conta = new ContaBancariaCorrecao(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine()! ,CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }

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
