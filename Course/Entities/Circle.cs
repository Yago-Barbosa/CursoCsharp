using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; } 

        public override double Area()
        {
            return (Radius * Radius) * Math.PI ;
        }

        public override string ToString()
        {
            return "Circle Color = " +
                    Color + ", Radius = " +
                    Radius.ToString("F2",CultureInfo.InvariantCulture) +
                    ", Area = " + 
                    Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
