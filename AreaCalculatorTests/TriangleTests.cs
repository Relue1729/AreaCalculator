using AreaCalculatorLibrary.Shapes;
using System;
using Xunit;

namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        Triangle triangle = new Triangle(7, 10, 5);

        [Fact]
        public void InitializationTest()
        {
            Assert.Equal(7,  triangle.A);
            Assert.Equal(10, triangle.B);
            Assert.Equal(5,  triangle.C);
        }

        [Fact]
        public void ThrowsOnNegativeSideLength()
        {
            Assert.Throws<ArgumentException>(() => triangle.A = -10);
            Assert.Throws<ArgumentException>(() => triangle.B = -10);
            Assert.Throws<ArgumentException>(() => triangle.C = -10);
        }

        [Theory]
        [InlineData(1, 10, 12)]
        [InlineData(0, 0,  25)]
        [InlineData(5, 5,  85)]
        public void ThrowsOnInvalidTriangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(7, 10, 5, 16.25)]
        [InlineData(24, 37.5, 14.4, 74.9)]
        [InlineData(23.7, 24, 33.8, 284.4)]
        public void GetAreaTest(double a, double b, double c, double expectedArea)
        {
            triangle = new Triangle(a, b, c);
            Assert.Equal(expectedArea, Math.Round(triangle.GetArea(), 2));
        }

        [Theory]
        [InlineData(3,  4,  5,   true)]
        [InlineData(5,  12, 13,  true)]
        [InlineData(20, 99, 101, true)]
        [InlineData(7,  10, 5,   false)]
        [InlineData(11, 12, 5,   false)]
        public void RightTriangleTest(double a, double b, double c, bool expected)
        {
            triangle = new Triangle(a, b, c);
            Assert.Equal(expected, triangle.IsRight());
        }
    }
}