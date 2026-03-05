using LibraryShape;

namespace GeometryTest
{
    public class TriangleTest
    {
        //тесты класса Triangle
        [Fact]
        public void TestTriangle_Input_ConstructorNull()
        {
            var result = new Triangle();
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(-1, 3, 4)]
        [InlineData(3, -1, 4)]
        [InlineData(3, 4, -1)]
        [InlineData(0, 3, 4)]
        [InlineData(3, 0, 4)]
        [InlineData(3, 4, 0)]
        [InlineData(-1, -2, 3)]
        [InlineData(0, 0, 0)]
        public void TestTriangle_Input_Constructor(double a, double b, double c)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.Equal("Стороны должны быть положительными числами", exception.Message);
        }

        [Theory]
        [InlineData(1, 2, 3)]     
        [InlineData(1, 2, 4)]     
        [InlineData(5, 1, 2)]    
        [InlineData(2, 5, 1)]   
        [InlineData(2, 1, 5)]   
        [InlineData(10, 2, 3)]  
        public void TestTriangle_Input_Constructor_IsValidTriangle(double a, double b, double c)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
            Assert.Equal("Треугольник с такими сторонами не существует", exception.Message);
        }

        [Fact]
        public void TestTriangle_Area()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.Area();
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestTriangle_Perimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.Perimeter();
            Assert.Equal(12, result);
        }

        [Fact]
        public void TestTriangle_ToString()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var answer = $"Треугольник: " +
                   $"стороны = {3}, {4}, {5}, " +
                   $"площадь = {6}" +
                   $"периметр = {12}";

            var result = triangle.ToString();
            Assert.Equal(answer, result);
        }
    }
}
