using System;
using System.Collections.Generic;
using System.Text;
using ExMetAbstractos.Entities.Enuns;

namespace ExMetAbstractos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
