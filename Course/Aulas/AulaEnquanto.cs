using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Aulas
{
    public class AulaEnquanto
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

        public static void For()
        {
            // Use mais quando souber a quantia para a condição, podendo ser uma contagem etc

            Console.Write("Quantos numeros vc vai digitar: ");
            int vezes = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1 ; i <= vezes; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
