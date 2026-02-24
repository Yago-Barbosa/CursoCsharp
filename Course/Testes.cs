using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            AtvClient.Exercicio();
            //Funcoes.Func();
        }
        static void test(string[] args)
        {
            double a = 1.0, b = -3.0 ,c = -4.0;

            double x1 = (-b + Math.Sqrt((Math.Pow(b, 2.0) - 4.0 * a * c))) / (2.0 * a);
            double x2 = (-b - Math.Sqrt((Math.Pow(b, 2.0) - 4.0 * a * c))) / (2.0 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
