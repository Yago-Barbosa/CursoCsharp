using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color){ 
            Radius = radius;
        }

        public override double Area()
        {
            return (Radius * Radius) * Math.PI ;
        }
    }
}
