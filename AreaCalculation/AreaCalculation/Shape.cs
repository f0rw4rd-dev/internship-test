namespace AreaCalculation
{
    public abstract class Shape
    {
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Валидирует, что заданное значение является положительным
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="propertyName">Название параметра</param>
        /// <returns>Заданное значение, если оно является положительным</returns>
        /// <exception cref="ArgumentOutOfRangeException">Возникает, если значение меньше или равно нулю</exception>
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
