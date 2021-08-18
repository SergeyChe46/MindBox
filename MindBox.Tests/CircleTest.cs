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
        private readonly Circle circle = new Circle(5);

        [Fact]
        public void CalculateRightSquare()
        {
            Assert.Equal(78.53981633974483, circle.CalculateSquare());
            Assert.IsType<double>(circle.CalculateSquare());
        }
    }
}
