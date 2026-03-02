using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Aulas
{
    internal class AulaClasseAbstrata
    {
        public static void ClassesAbstratas()
        {
            // Classes abstratas não podem ser instanciadas, somente suas subclasses podem
            // Porque fazer isso e não só criar as classes business e savings?
            // Resposta: Reuso e Polimorfismo(permite tratar de forma fácil e uniforme todos os tipos de conta) 


            // Ex : Classe Account feita anteriormente

            // Nesse caso a conta acc1 não poderá ser instanciada
            // Account acc1 = new Account(1001, "Alex", 500.0);

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated Balance for account " + acc.Number + ": " + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
        } 
    }
}
