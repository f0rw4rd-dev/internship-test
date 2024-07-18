using Xunit;
using AreaCalculation;

namespace AreaCalculationTest
{
    public class CircleTest
    {
        [Fact]
        public void Circle_NegativeRadius_ThrowsArgumentOutOfRangeException()
        {
            double radius = -1e-5;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_ZeroRadius_ThrowsArgumentOutOfRangeException()
        {
            double radius = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_PositiveRadius_NoArgumentOutOfRangeException()
        {
            double radius = 1e-6;
            Circle circle = new(radius);

            Assert.Equal(radius, circle.Radius);
        }

        [Fact]
        public void CalculateArea_SmallRadius_ReturnsCorrectArea()
        {
            double radius = 5e-7;
            Circle circle = new(radius);

            double area = circle.CalculateArea();

            Assert.True(Math.Abs(Math.PI * 25 * 1e-14 - area) < 1e-6);
        }

        [Fact]
        public void CalculateArea_BigRadius_ReturnsCorrectArea()
        {
            double radius = 2.3e6;
            Circle circle = new(radius);

            double area = circle.CalculateArea();

            Assert.True(Math.Abs(Math.PI * 5.29 * 1e12 - area) < 1e-6);
        }
    }
}