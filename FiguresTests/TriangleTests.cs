using FiguresLibrary.Models;

namespace FiguresTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 3, 5)]
        public void Constructor_ShouldReturnInstanceReference_IsExist(double sideA, double sideB, double hypotenuse)
        {
            var triangle = new Triangle(sideA, sideB, hypotenuse);
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(hypotenuse, triangle.Hypotenuse);
        }

        [Theory]
        [InlineData(2, 6, 9)]
        public void Constructor_ShouldReturnInstanceReference_IsNotExists(double sideA, double sideB, double hypotenuse)
        {
            Assert.Throws<ArgumentException>(() => _ = new Triangle(sideA, sideB, hypotenuse));
        }

        [Theory]
        [InlineData(4, 5, 6)]
        public void IsRight_ShouldReturnTrue_WhenTriangleIsRight(double sideA, double sideB, double hypotenuse)
        {
            var triangle = new Triangle(sideA, sideB, hypotenuse);
            Assert.True(triangle.CheckForRightTriangle());
        }

        [Theory]
        [InlineData(4, 3, 6)]
        public void IsRight_ShouldReturnFalse_WhenTriangleNotRight(double sideA, double sideB, double hypotenuse)
        {
            var triangle = new Triangle(sideA, sideB, hypotenuse);
            Assert.False(triangle.CheckForRightTriangle());
        }
    }
}
