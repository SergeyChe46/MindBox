using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    class ShapeInformer
    {
        public ShapeInformer(IEnumerable<IShape> shapes)
        {
            foreach(IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateSquare());
            }
        }
    }
}
