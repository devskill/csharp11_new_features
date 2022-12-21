using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMathSupport
{
    public class Point<T> where T: INumber<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point<T> Sum(Point<T> point)
        {
            return new Point<T>() { X = this.X + point.X, 
                Y = this.Y + point.Y };
        }
    }
}
