using AbstractObjects.Entities;
using AbstractObjects.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AbstractObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>(); 

            Console.WriteLine("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com dados da figua#{i}: ");
                Console.Write("Retangulo ou Circulo? (r/c)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Qual cor? (Black/Blue/Red)");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapeList.Add(new Rectangle(width, height, color));

                }
                else
                {
                    Console.WriteLine("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapeList.Add(new Cicle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Area das figura: ");

            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
