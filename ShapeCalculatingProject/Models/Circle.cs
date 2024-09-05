using ShapeCalculatingProject.Interfaces;

namespace ShapeCalculatingProject.Models
{
    public class Circle : IShape
    {
        public double CircleRadius { get; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive.");
            CircleRadius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(CircleRadius, 2);
        }
    }
}
