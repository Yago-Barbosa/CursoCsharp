using Course.Entities;
using Course.Entities.Exceptions;
using System.Globalization;

namespace Course.Atividades
{
    internal class AtvContaBancaria
    {
        public static void Exercicio()
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine()!);
                Console.Write("Holder: ");
                string holder = Console.ReadLine()!;
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter the amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine("New Balance: " + account.Balance.ToString("f2", CultureInfo.InvariantCulture));

            }
            catch (DomainException error)
            {
                Console.WriteLine("Withdraw error: " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected Error! " + error.Message);
            }
        }
    }
}
