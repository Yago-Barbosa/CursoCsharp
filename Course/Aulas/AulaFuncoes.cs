using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    public class AulaFuncoes
    {
        public static void Func()
        {
            Console.WriteLine("Digite 3 números um de cada vez: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("O Maior é " + resultado);
        }

        static int Maior(int a, int b, int c){
            int m;
            if(a > b && a > c)
                m = a;
            else if (b > c)
                m = b;
            else
                m = c;
            return m;
        }
    }
}
