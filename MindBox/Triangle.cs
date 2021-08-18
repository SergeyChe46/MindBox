using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Triangle : IShape
    {
        private double[] sides = new double[3];
        private double halfPerimeter => (sides[0] + sides[1] + sides[2]) / 2;

        public Triangle(double sideA, double sideB, double sideC)
        {
            sides[0] = sideA; 
            sides[1] = sideB;
            sides[2] = sideC;
        }

        public double CalculateSquare()
        {
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));
        }

        public bool IsRectangular()
        {
            double hypotenuse = sides.Max();
            double[] cathetus = sides.OrderBy(s => s).SkipLast(1).ToArray();

            return Math.Pow(hypotenuse, 2) == Math.Pow(cathetus[0], 2) + Math.Pow(cathetus[1], 2);
        }
    }
}
