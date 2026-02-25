using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaOperadoresConversoes
    {
        static void Lesson(string[] args) // Trocar para Main caso eu queria executar
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2; // a = a + 2 (10 + 2 = 12)
            Console.WriteLine(a);
            a *= 3; // a = a * 3 (12 * 3 = 36)
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF"; // Tambem serve para concatenação cumulativa de Strings
            Console.WriteLine(s);

            int b = ++a; // b = 36(a) + 1 = 37
            // a++(primeiro aumenta o valor do a somente), ++a(atribui a var b com o valor de a + 1 tambem)
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void M(string[] args)
        {
            float a = 4.5f;
            // é possivel converter implicitamente para double pois o float ocupa 4 bytes e o double 8
            double b = a;

            double x = 4.5;
            // O contrario não é possivel, pois haveria chance de perda de dados, informações, de 8 bytes para 4
            float y = (float)x;
            /* É necessario usar o Casting para fazer a conversão explicita
            // A conversão tambem pode alterar o valor para se adequar ao tipo novo
             Ex: 5.1(tipo float) -> 5(tipo int */

            /* O resultado será 1 pois foi uma divisao dos 2 numeros inteiros,
             * tmb é necessario casting ou uma especificação(10.0 ou 8.0,) */
            double teste = 10 / 8;

            Console.WriteLine(y + " e " + teste);
        }
    }
}