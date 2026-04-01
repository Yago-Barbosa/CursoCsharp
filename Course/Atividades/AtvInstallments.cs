using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    internal class AtvInstallments
    {
        public static void Exercicio()
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly date = DateOnly.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine()!);
            for(int i = 1; i <= installments; i++)
            {

            }
        }
    }
}
