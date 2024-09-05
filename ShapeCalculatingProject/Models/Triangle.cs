using ShapeCalculatingProject.Interfaces;

namespace ShapeCalculatingProject.Models
{
    public class Triangle : IShape
    {
        public double TriangleSideA { get; }
        public double TriangleSideB { get; }
        public double TriangleSideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Sides must be positive");

            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("The sides don't form a valid triangle");

            TriangleSideA = sideA;
            TriangleSideB = sideB;
            TriangleSideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (TriangleSideA + TriangleSideB + TriangleSideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - TriangleSideA) * 
                (semiPerimeter - TriangleSideB) * (semiPerimeter - TriangleSideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { TriangleSideA, TriangleSideB, TriangleSideC };
            Array.Sort(sides);
            return Math.Pow(sides[2],2) == Math.Pow(sides[0],2) + Math.Pow(sides[1],2);
        }

        private static bool IsValidTriangle(double a, double b, double c) => a + b > c && a + c > b && b + c > a;
    }
}
