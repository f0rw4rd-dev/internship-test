using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Triangle : Shape, IRectangular
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get => _sideA;
            set => _sideA = ValidatePositiveValue(value, nameof(SideA));
        }

        public double SideB
        {
            get => _sideB;
            set => _sideB = ValidatePositiveValue(value, nameof(SideB));
        }

        public double SideC
        {
            get => _sideC;
            set => _sideC = ValidatePositiveValue(value, nameof(SideC));
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRectangular()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Abs(sides[2] * sides[2] - sides[0] * sides[0] - sides[1] * sides[1]) < 1e-6;
        }
    }
}
