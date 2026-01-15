using System;

namespace Course
{
    internal class Tipos
    {
        static void Second (string[] args)
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';// letra A pelo código Unicode

            int n1 = int.MaxValue;// é possivel usar essa func em todos os nums
            int n2 = 2147483647;
            long n3 = 2145483648;
            float n4 = 4.5f;// É necessário o "f" de sufixo
            double n5 = 4.5;
            string nome = "Yago Barbosa";// string é IMUTAVEL por segurança
            object obj1 = "Alex";
            object obj2 = 4.5f;

            Console.WriteLine(nome);
            Console.WriteLine(letra);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

        }
    }
}