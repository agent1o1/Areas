using System;
using Areas.Interfaces;

namespace Areas.Concrete
{
    public class Triangle : IFigure
    {
        private double Area { get; set; }

        public double FirstSide { get; set; }

        public double SecondSide { get; set; }

        public double ThirdSide { get; set; }


        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Введённые длины сторон должны быть положительными числами!");
            }

            if (firstSide + secondSide < thirdSide ||
                firstSide + thirdSide < secondSide ||
                secondSide + thirdSide < firstSide)
            {
                throw new ArgumentException("Введённые длины сторон треугольника неверны!");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRightTriangle()
        {
            return (Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2) ||
                    Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(SecondSide, 2) ||
                    Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2));
        }

        public double GetArea()
        {
            CalculateTriangleAreaByThreeSides();
            return Area;
        }

        private void CalculateTriangleAreaByThreeSides()
        {
            var p = (FirstSide + SecondSide + ThirdSide) / 2;

            var formula = p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide);

            Area = Math.Sqrt(formula);
        }
    }
}