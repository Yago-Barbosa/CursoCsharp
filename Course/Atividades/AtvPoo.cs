using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Course.Entities;

namespace Course.Atividades
{
    public class AtvPoo
    {
        public static void Exemplo()
        {
            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do Triângulo X: ");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre com as medidas do Triângulo Y:");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            //Console.WriteLine("Triangulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Triangulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if(areaX > areaY)
            //{
            //    Console.WriteLine("Maior área = X");
            //} else if(areaY > areaX){
            //    Console.WriteLine("Maior área = Y");
            //}
            //else
            //{
            //    Console.WriteLine("As áreas são iguais");
            //}
        }

        public static void Pratica()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do Triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            
            double areaY = y.Area();

            Console.WriteLine("Triangulo X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Triangulo Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("Maior área = Y");
            }
            else
            {
                Console.WriteLine("As áreas são iguais");
            }
        }
    }
}
