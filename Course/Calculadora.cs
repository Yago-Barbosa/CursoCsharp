using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    internal class Calculadora
    {
        // adicionar o params permite que os parametros sejam passados de maneira "simples"
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Para que essa função realmente funcione é necessario usar o Ref, no qual ira transformar o x em uma referencia para a variavel original
        public static void TripleRef(ref int x)
        {
            x = x * 3;
        }

        // o modificador Out é similar ao ref (faz o parâmetro ser uma referência para a variável original),
        // mas não exige que a variável original seja iniciada.
        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
