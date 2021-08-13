using AreaCalculatorLibrary.Shapes;
using System;
using Xunit;

namespace AreaCalculatorTests
{
    public class CircleTests
    {
        Circle circle = new Circle(10);
        
        [Fact]
        public void InitializationTest()
        {
            Assert.Equal(10, circle.Radius);
        }

        [Fact]
        public void ThrowsOnNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => circle.Radius = -10);
        }

        [Theory]
        [InlineData(10, 314.16)]
        [InlineData(1, 3.14)]
        [InlineData(5, 78.54)]
        [InlineData(28.7, 2587.7)]
        public void GetAreaTest(double radius, double expectedArea)
        {
            circle.Radius = radius;
            Assert.Equal(expectedArea, Math.Round(circle.GetArea(), 2));
        }
    }
}