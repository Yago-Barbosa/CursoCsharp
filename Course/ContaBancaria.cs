using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    internal class ContaBancaria
    {
        private string Id { get; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(string id, string nome, double saldo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }

        public void Depositar(double d)
        {
            if (d > 0.0){
                Saldo += d;
            } else {
                Console.WriteLine("Impossivel depositar um valor negativo");
            }
        }
        public void Saque(double d)
        {
            Saldo = (Saldo - 5.00) - d;
           
        }

        public override string ToString()
        {
            return "Conta " + Id +
                   ", Titular: " + 
                   Nome + 
                   ", Saldo: R$" +
                   Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
