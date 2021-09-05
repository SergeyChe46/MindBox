using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MindBox.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(5, 1, 1)]
        [InlineData(-3, 6, 0)]
        [InlineData(0, 0, 1)]
        [InlineData(-1, -1, 1)]
        [InlineData(2, 1, 0)]
        public void TriangleCantExist(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculateSquareTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.Equal(6, triangle.CalculateSquare());            
        }

        [Fact]
        public void IsThisRectangular()
        {
            Triangle Rectangulartriangle = new Triangle(3, 4, 5);
            Triangle NotRectangulartriangle1 = new Triangle(2, 3, 4);

            Assert.True(Rectangulartriangle.IsRectangular());
            Assert.False(NotRectangulartriangle1.IsRectangular());
        }
    }
}
