using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius 
        {
            get => _radius;
            set => _radius = ValidatePositiveValue(value, nameof(Radius));
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
