using Course.Entities;
using Course.Entities.Enums;
using System;

namespace Course.Aulas
{
    internal class AulaAbstractAndInterface
    {
        public static void Aula()
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
