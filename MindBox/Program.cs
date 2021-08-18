using System;
using System.Collections.Generic;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавить новую фигуру
            IEnumerable<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Triangle(3, 4, 5)
            };

            ShapeInformer informer = new(shapes);
        }
    }
}
