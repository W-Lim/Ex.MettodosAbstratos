using System;
using System.Collections.Generic;
using System.Text;
using ExMetAbstractos.Entities.Enuns;
using System.Globalization;

namespace ExMetAbstractos.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius ;
        }

        public override string ToString()
        {
            return "Circle color"
                + Color
                + ", Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
