using Xunit;
using AreaCalculation;

namespace AreaCalculationTest
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_NegativeSideA_ThrowsArgumentOutOfRangeException()
        {
            double sideA = -1e-6, sideB = 2, sideC = 8e-2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_NegativeSideB_ThrowsArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = -1e-6, sideC = 8e-2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_NegativeSideC_ThrowsArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = 8e-2, sideC = -1e-6;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_ZeroSideA_ThrowsArgumentOutOfRangeException()
        {
            double sideA = 0, sideB = 2, sideC = 8e-2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_ZeroSideB_ThrowsArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = 0, sideC = 8e-2;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_ZeroSideC_ThrowsArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = 8e-2, sideC = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_PositiveSideA_NoArgumentOutOfRangeException()
        {
            double sideA = 7.8e-3, sideB = 2, sideC = 8e-2;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void Triangle_PositiveSideB_NoArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = 1.2, sideC = 8e-2;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void Triangle_PositiveSideC_NoArgumentOutOfRangeException()
        {
            double sideA = 2, sideB = 8e-2, sideC = 3.15;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void CalculateArea_NonExistingTriangle_ReturnsNaN()
        {
            double sideA = 1e-2, sideB = 7e-1, sideC = 3.15e-3;
            Triangle triangle = new(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.Equal(double.NaN, area);
        }

        [Fact]
        public void CalculateArea_ExistingTriangle_ReturnsCorrectArea()
        {
            double sideA = 31.549, sideB = 57.124, sideC = 49.151;
            Triangle triangle = new(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.True(Math.Abs(774.448993777 - area) < 1e-6);
        }

        [Fact]
        public void IsRectangular_AngleABCIsRight_ReturnsTrue()
        {
            double sideA = 3.59, sideB = 7.19034074297, sideC = 6.23;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsRectangular_AngleBACIsRight_ReturnsTrue()
        {
            double sideA = 8.53098470283, sideB = 7.21, sideC = 4.56;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsRectangular_AngleBCAIsRight_ReturnsTrue()
        {
            double sideA = 1.87, sideB = 3.23, sideC = 3.73226472802;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsRectangular_NoAngleIsRight_ReturnsFalse()
        {
            double sideA = 10.8673, sideB = 7.77, sideC = 8.97;
            Triangle triangle = new(sideA, sideB, sideC);

            Assert.False(triangle.IsRectangular());
        }
    }
}