using FiguresLibrary.Abstractions;


namespace FiguresLibrary.Models
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Hypotenuse { get; set; }

        private const double Tolerance = 1e-17;

        public Triangle(double sideA, double sideB, double hypotenuse)
        {
            if (!IsExists(sideA, sideB, hypotenuse))
            {
                throw new ArgumentException("Треугольника не существует. Сумма любых двух сторон должна быть больше третьей");
            }

            SideA = sideA;
            SideB = sideB;
            Hypotenuse = hypotenuse;
        }

        public double CalculateArea()
        {
            var semiPerimeter = (SideA + SideB + Hypotenuse) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - Hypotenuse));
            return area;
        }

        public bool CheckForRightTriangle()
        {
            return Math.Abs(Math.Pow(Hypotenuse, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) < Tolerance;
        }

        public static bool IsExists(double sideA, double sideB, double hypotenuse)
        {
            return
                sideA + sideB > hypotenuse
                && sideB + hypotenuse > sideA
                && sideA + hypotenuse > sideB;
        }
    }
}
