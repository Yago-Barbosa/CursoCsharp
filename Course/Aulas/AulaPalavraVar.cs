using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Aulas
{
    internal class AulaPalavraVar
    {
        public static void Aula()
        {
            // Ao usar o Var, o c# automaticamente infere o tipo da variavel baseado no seu valor

            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
