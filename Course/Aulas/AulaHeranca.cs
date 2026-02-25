using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaHeranca
    {
        public static void TestePratico()
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);


            // Ao usar o protected no atributo balance, ele só pode ser alterado na sua classe ou em subclasses 
            // account.Balance = 200;
        }
    }
}
