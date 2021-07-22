using System;
using System.Collections.Generic;
using System.Text;
using ExMetAbstractos.Entities.Enuns;
using System.Globalization;

namespace ExMetAbstractos.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double heigth, Color color)
            : base (color)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Area()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return "Rectangle color: "
                + Color
                +", Widht = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Height = "
                + Heigth.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
