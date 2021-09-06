using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Triangle : IShape
    {
        //Проверяем может ли быть такой треугольник
        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Такого треугольника быть не может");
            }
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
        //И если такой треугольник математически может быть,
        //то проверяем, что его стороны неотрицательны
        public double SideA
        {
            get => sideA;
            set
            {
                CheckSide(value, ref sideA);
            }
        }
        public double SideB
        {
            get => sideB;
            set
            {
                CheckSide(value, ref sideB);
            }
        }
        public double SideC
        {
            get => sideC;
            set
            {
                CheckSide(value, ref sideC);
            }
        }
        
        private double sideA;
        private double sideB;
        private double sideC;
        private double halfPerimeter => (sideA + sideB + sideC) / 2;
        private void CheckSide(double value, ref double side)
        {
            if (value < 0)
            {
                throw new ArgumentException("Длина стороны не может быть отрицательной");
            }
            side = value;
        }
    }
}

