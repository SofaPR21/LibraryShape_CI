using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) 
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Ширина и высота должны быть не отрицательными числами");
            }

            Width = width;
            Height = height;
        }

        public Rectangle() { }

        public override double Area()
        {
            return Width * Height;
        }
        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public override string ToString()
        {
            return $"Прямоугольник: " +
                   $"ширина = {Width} " +
                   $"высота = {Height}, " +
                   $"площадь = {Area():F2}" +
                   $"периметр = {Perimeter():F2}";
        }
    }
}
