using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными числами");
            }

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами не существует");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public Triangle() { }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter *
                           (semiPerimeter - SideA) *
                           (semiPerimeter - SideB) *
                           (semiPerimeter - SideC));
        }
       
        public override string ToString()
        {
            return $"Треугольник: " +
                   $"стороны = {SideA}, {SideB}, {SideC}, " +
                   $"площадь = {Area():F2}" +
                   $"периметр = {Perimeter():F2}";
        }
    }
}
