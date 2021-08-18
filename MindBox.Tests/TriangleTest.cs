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
        private readonly Triangle triangle = new Triangle(3, 4, 5);
        private readonly Triangle triangle1 = new Triangle(2, 3, 4);

        [Fact]
        public void CalculateRightSquare()
        {
            Assert.Equal(6, triangle.CalculateSquare());
            Assert.IsType<double>(triangle.CalculateSquare());            
        }

        [Fact]
        public void IsThisRectangular()
        {
            Assert.True(triangle.IsRectangular());
            Assert.False(triangle1.IsRectangular());
        }
    }
}
