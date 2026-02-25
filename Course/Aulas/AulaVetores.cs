using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Aulas
{
    class AulaVetores
    {
        public static void Exemplo2()
        {
            Console.Write("Quantos produtos vao ser lidos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            // como o vetor agora é do tipo classe, seus objetos tambem deverão ser instanciados

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect [i] = new Produto { Nome = name, Preco = price };
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect [i].Preco;
            }

            double avg = sum / n;

            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
        public static void Exemplo1()
        {
            Console.Write("Digite a quantidades de pessoas: ");
            int n = int.Parse(Console.ReadLine()!); 
            // vetor vai ter seu tamanho baseado no n...
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++)
            {
                alturas[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += alturas[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average height = " + avg.ToString("f2", CultureInfo.InvariantCulture));
        }  
    }
}
