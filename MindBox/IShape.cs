using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    //Для добавления новых типов фигур достаточно реализовать интерфейс 
    interface IShape
    {
        public double CalculateSquare();
    }
}
