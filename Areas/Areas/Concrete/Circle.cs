using System;
using Areas.Interfaces;

namespace Areas.Concrete
{
    public class Circle : IFigure
    {
        private double Area { get; set; }

        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Неверный радиус круга.");
            }

            Radius = radius;
        }

        public double GetArea()
        {
            CalculateСircleAreaByRadius();
            return Area;
        }

        private void CalculateСircleAreaByRadius()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
        }
    }
}