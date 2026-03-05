using LibraryShape;

namespace GeometryTest
{
    public class RectangleTest
    {
        //тесты класса Rectangle
        [Fact]
        public void TestRectangle_Input_ConstructorNull()
        {
            var result = new Rectangle();
            Assert.NotNull(result);
        }

        [Fact]
        public void TestRectangle_InputAll()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(-6, -3));
        }

        [Fact]
        public void TestRectangle_Input_Width()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(-6, 3));
        }

        [Fact]
        public void TestRectangle_Input_Height()
        {
            Assert.Throws<ArgumentException>(() => new Rectangle(6, -3));
        }

        [Fact]
        public void TestRectangle_Area()
        {
            Rectangle rectangle = new Rectangle(6, 3);
            var result = rectangle.Area();
            Assert.Equal(18, result);
        }

        [Fact]
        public void TestRectangle_Perimeter()
        {
            Rectangle rectangle = new Rectangle(6, 3);
            var result = rectangle.Perimeter();
            Assert.Equal(18, result);
        }

        [Fact]
        public void TestRectangle_ToString()
        {
            Rectangle rectangle = new Rectangle(6, 3);
            var answer = $"Прямоугольник: " +
                   $"ширина = {6} " +
                   $"высота = {3}, " +
                   $"площадь = {18}" +
                   $"периметр = {18}";

            var result = rectangle.ToString();
            Assert.Equal(answer, result);
        }
    }
}
