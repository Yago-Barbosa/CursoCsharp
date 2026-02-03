using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    internal class AulaParams
    {
        static void Exemplo()
        {
            // sem o params
            // int s1 = Calculadora.Sum(new int[] { 4, 5 });

            // Com o params, não é preciso instanciar um vetor
            int s2 = Calculadora.Sum(5, 7);

            Console.WriteLine(s2);
        }
    }
}
