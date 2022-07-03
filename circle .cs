using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Shape
{

    class Circle : Shape
    {
        static double PI = 3.14;
        int _radius;
        public int radius
        {
            get => _radius;
            set => _radius = value;
        }
        public double getArea()
        {
            return PI * (radius * radius);

        }
        public double getPerimeter()
        {
            return 2 * PI * radius
                ;
        }

    }
}
