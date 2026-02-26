using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaOverride
    {
        public static void Override()
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
