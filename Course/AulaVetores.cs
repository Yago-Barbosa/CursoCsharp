using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class AulaVetores
    {
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
