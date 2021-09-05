using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Triangle : IShape
    {
        //проверка аргументов в конструкторе а не в свойствах для уменьшения объёма кода
        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA >= 0 && sideB >= 0 && sideC >= 0)
                {
                if (sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
                {
                    this.sideA = sideA;
                    this.sideB = sideB;
                    this.sideC = sideC;
                }
                else throw new ArgumentException("Такого треугольника не существет");
                }
            else throw new ArgumentException("Длины сторон не могут быть меньше нуля");
        }

        public double CalculateSquare()
        {
            return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }

        //если квадрат гипотенузы равен сумме квадратов катетов - True
        public bool IsRectangular()
        {
            double[] sides = { sideA, sideB, sideC };

            double hypotenuse = sides.Max();
            double[] cathetus = sides.OrderBy(s => s).SkipLast(1).ToArray();
            return Math.Pow(hypotenuse, 2) == Math.Pow(cathetus[0], 2) + Math.Pow(cathetus[1], 2);
        }

        private double halfPerimeter => (sideA + sideB + sideC) / 2;

        private double sideA;
        private double sideB;
        private double sideC;
    }
}
