using System;
using System.Collections.Generic;
using System.Text;
using ExMetAbstractos.Entities.Enuns;

namespace ExMetAbstractos.Entities
{
    abstract class AbstractShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
