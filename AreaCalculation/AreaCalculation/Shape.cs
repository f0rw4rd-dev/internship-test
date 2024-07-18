namespace AreaCalculation
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        protected static double ValidatePositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(propertyName, "Value must be positive");
            }

            return value;
        }
    }
}
