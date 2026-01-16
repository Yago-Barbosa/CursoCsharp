using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    public class Enquanto
    {
        public static void While()
        {

            Console.Write("Digite um numero para ver sua raiz quadrada (Sem numeros negativos): ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(n > 0.0) {
                Console.WriteLine("A Raiz quadrada de " + n.ToString(CultureInfo.InvariantCulture) + " é igual a: " + Math.Sqrt(n).ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo, encerrando o programa...");
        }
    }
}
