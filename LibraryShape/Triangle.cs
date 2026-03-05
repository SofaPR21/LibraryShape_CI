using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle() { }

        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть положительными числами");
            }

            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
       
        public override string ToString()
        {
            return $"Треугольник: " +
                   $"стороны = {SideA}, {SideB}, {SideC}, " +
                   $"площадь = {Area()}" +
                   $"периметр = {Perimeter()}";
        }
    }
}
