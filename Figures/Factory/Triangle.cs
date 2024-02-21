using System;

namespace Figures.Factory
{
    public class Triangle : AbstractFigureFactory
    {
        public Triangle(int side1, int side2, int side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public int _side1 { get; }
        public int _side2 { get; }
        public int _side3 { get; }

        public override double AreaCalculation()
        {
            double s = (double)(_side1 + _side2 + _side3) / 2;

            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }
    }
}
