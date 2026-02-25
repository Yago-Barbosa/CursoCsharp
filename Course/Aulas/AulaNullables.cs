using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaNullables
    {
        static public void Aula()
        {
            double? x = null;
            double? y = 10.0;

            // --------- Coalescência Nula ---------

            // se x possuir um valor então a recebe x senão a recebe 5
            double a = x ?? 5;
            // se y possuir um valor então b recebe y senão b recebe 5
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            // double x = null; x não pode receber null pois ele é "non-nullable"


            // Agora o x pode receber valor null
            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue) 
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("X is null");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Y is null");
        }
    }
}
