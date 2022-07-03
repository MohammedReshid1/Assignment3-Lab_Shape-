using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_shape
{
    class Square : Shape
    {
        int _length;
        int _width;
        public int length

        {
            get { return _length; }
            set { _length = value; }
        }

        public int width
        {
            get { return _width; }
            set { _width = value; }
        }
        public double getArea()
        {
            return width * length;

        }
        public double getPerimeter()
        {
            return 2 * (width + length);
        }
    }
}
