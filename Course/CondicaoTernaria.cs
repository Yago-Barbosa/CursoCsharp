using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    internal class CondicaoTernaria
    {
        public static void Aula()
        {
            double preco = double.Parse(Console.ReadLine()!,CultureInfo.InvariantCulture);
            // Condição Ternaria (economiza linhas) = (condição) ? Valor_True : Valor_False
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; 

            //if (preco < 20.0){
            //    desconto = preco * 0.1;
            //}
            //else {
            //    desconto = preco * 0.05;
            //}
            Console.WriteLine(desconto);
        }
    }
}
