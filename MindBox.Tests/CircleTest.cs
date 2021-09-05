using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBox.Tests
{
    public class CircleTest
    {
        [Fact]
        public void CalculateSquareTest()
        {            
            Circle circle = new Circle(5);

            double expected = circle.CalculateSquare();

            Assert.Equal(Math.PI * Math.Pow(circle.Radius, 2), expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-65)]
        public void NegativeArgumentTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
