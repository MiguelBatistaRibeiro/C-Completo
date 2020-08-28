using AbstractObjects.Entities.Enums;
using System;

namespace AbstractObjects.Entities
{
    class Cicle : Shape
    {
        public double Radius { get; set; }
        public Cicle(double radius, Color color) :base(color)
        {
            Radius = radius;
        }
       public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }    
}
    