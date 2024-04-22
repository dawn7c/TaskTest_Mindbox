using FiguresLibrary.Models;

namespace FiguresTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(32)]
        [InlineData(33.3)]
        public void Constructor_ShouldReturnInstanceReference_WhenRadiusGreaterThenZero(double radius)
        {
            var circle = new Circle(radius);
            Assert.Equal(radius, circle.Radius);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-3)]
        [InlineData(-10.35)]
        public void Constructor_ShouldThrowArgumentException_WhenRadiusLessOrEqualZero(double radius)
        {
            Assert.Throws<ArgumentException>(() => _ = new Circle(radius));
        }

        [Theory]
        [InlineData(1, 3.1415926535897931)]
        [InlineData(4.5, 63.617251235193308)]  

        public void CalculateArea_ShouldReturnArea_WhenRadiusGreaterThenZero(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            var area = circle.CalculateArea();
            Assert.Equal(expectedArea, area);
        }
    }

}
