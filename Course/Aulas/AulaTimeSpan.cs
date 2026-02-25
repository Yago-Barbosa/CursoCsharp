using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaTimeSpan
    {
        public static void AulaFuncoesExtra()
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            //TimeSpan t1 = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t1);
            //// Days devolve a quantidade inteira de dias
            //Console.WriteLine("Days: " + t1.Days);
            //// TotalDays devolve a quantidade total de dias, mesmo que seja uma fração
            //Console.WriteLine("TotalDays: " + t1.TotalDays);
        }
        public static void Aula()
        {
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            // Armazena uma duração(hh,mm,ss)

            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
        }
    }
}
