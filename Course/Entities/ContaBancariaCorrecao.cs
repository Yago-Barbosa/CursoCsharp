using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    internal class ContaBancariaCorrecao
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancariaCorrecao(int numero, string titular){
            Numero = numero;
            Titular = titular;
        }

        public ContaBancariaCorrecao(int numero, string titular, double depositoInicial) : this(numero, titular){
            Deposito(depositoInicial);

            // Somente o método deposito pode "aumentar o saldo"
            // Errado (Saldo = saldo)
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
