using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaParams
    {
        public static void Params()
        {
            // sem o params
            // int s1 = Calculadora.Sum(new int[] { 4, 5 });

            // Com o params, não é preciso instanciar um vetor
            int s2 = Calculadora.Sum(5, 7);

            Console.WriteLine(s2);
        }

        public static void Ref()
        {
            int a = 10;

            // Usar o ref aqui também...
            Calculadora.TripleRef(ref a);
            Console.WriteLine(a);
        }

        public static void Out()
        {
            int a = 10;
            int triple;
            Calculadora.TripleOut(a, out triple);
            Console.WriteLine(triple);
            // o modificador Out é similar ao ref (faz o parâmetro ser uma referência para a variável original),
            // mas não exige que a variável original seja iniciada.
        }
    }
}
