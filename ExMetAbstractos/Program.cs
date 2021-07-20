using System;
using System.Collections.Generic;
using ExMetAbstractos.Entities.Enuns;
using ExMetAbstractos.Entities;
using System.Globalization;

namespace ExMetAbstractos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or Circle (r/c)?");
                string op = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red):");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (op == "r")
                {
                    
                    Console.Write("Width: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(widht, heigth, color));

                }
                else
                {
                    
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
            
        }
    }
}
