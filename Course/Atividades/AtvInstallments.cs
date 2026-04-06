using Course.Entities;
using System;
using System.Collections.Generic;
using Course.Services;
using System.Globalization;
using System.Text;

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
            DateTime date = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine()!);

            Contract contract = new Contract(number, date, totalValue);


            PaymentService contractService = new PaymentService(new PayPalPaymentService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
