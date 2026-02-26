using Course.Entities;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Course.Aulas
{
    internal class AulaUpcasting
    {
        public static void UpDown()
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting 

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // Downcasting - Obs (é uma operação insegura)

            // Tentar converter assim dará erro, pois o c# não sabe que o acc2 está associado a um businessaccount
            // BusinessAccount acc4 = acc2;

            // Então é necessario uma conversão
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // Embora não seja mostrado, a classe SavingsAccount não é compativel com a BusinessAccount, então na hora da execução um erro acontecerá
            // BusinessAccount acc5 = (BusinessAccount)acc3;

            // Is testa se a variavel(acc3) é um instancia do BusinessAccount
            if(acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                // Sintaxe alternativa
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
