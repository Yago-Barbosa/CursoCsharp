using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaOpLogicos
    {
        static void Conditions(string[] args)
        {
            // Precedência: ! > && > ||
            bool c1 = 2 > 3 || 4 != 5; // true
            bool c2 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("-------------------------");
            bool c3 = 10 < 5; // false 
            bool c4 = c1 || c2 && c3;// true ou true e false = true

            Console.WriteLine(c4);
        }
    }
}
