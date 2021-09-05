using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0) throw new ArgumentException("Радиус должен быть больше нуля");
                else radius = value;
            }
        }

        private double radius;
    }
}
