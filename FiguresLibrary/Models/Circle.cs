using FiguresLibrary.Abstractions;

namespace FiguresLibrary.Models
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            if (!CheckPositiveRadius(radius))
            {
                throw new ArgumentException("Радиус должен быть положительным числом, больше 0");
            }
            Radius = radius;
        }

        public double CalculateArea()
        {
            
            return Math.PI * Radius * Radius;
        }

        private bool CheckPositiveRadius(double radius) => radius > 0;
    }
}
