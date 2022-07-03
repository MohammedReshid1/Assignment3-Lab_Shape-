using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Shape
{
    class Triangle: Shape
    {
        int _base;
        int _height;
        int _length1;
        int _length2;
    public int base1{
        get => _base;
        set => _base = value;
        }
    public int height
    {
        get => _height; 
            set => _height = value;
    }
        public int length1
        {
            get => _length1;
            set => _length1 = value;
        }
        public int lenght2
        {
            get => _length2;
            set => _length2 = value;
        }
        public double getArea()
        {
            return 1/2*(base1*height);

        }
        public double getPerimeter()
        {
            return length1 + _length2 + base1 ;
        }


    }
}
