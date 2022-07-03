using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice_shape
{
    
     class major
    {
        public static void Main(string[] args)
        { Console.WriteLine("Welcome to measurement calculator!");
            Console.WriteLine("What would you like to do ?");
            Console.WriteLine("1.Calculate area and perimeter of a circle");
            Console.WriteLine("2.Calculate area of a square");
            Console.WriteLine("3.Calculate area of a triangle");
            Console.WriteLine("press any other button to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
        
    

           if (choice == 1)
            {
                Circle Circle = new circle();
                Console.WriteLine("AREA AND PERIMETER OF A CIRCLE");
                Console.WriteLine("Enter your radus");
                circle.radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The area of the circle is: ");
                Console.WriteLine(circle.getArea());
                Console.WriteLine("The Perimeter of the circle is: ");
                Console.WriteLine(circle.getPerimeter());
                Console.WriteLine("--------------------------------");
            }
            else if (choice == 2)
            {
                Console.WriteLine("AREA AND PERIMETER OF A SQUARE");
                Square square = new Square();
                Console.WriteLine("Enter your length");
                square.length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your width");
                square.width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The area of the square is: ");
                Console.WriteLine(square.getArea());
                Console.WriteLine("The Perimeter of the square is: ");
                Console.WriteLine(square.getPerimeter());
                Console.WriteLine("-------------------------------------");
            }
            else if (choice == 3)
            {
                Console.WriteLine("AREA AND PERIMETER OF A TRIANGLE");
                Triangle triangle = new Triangle();
                Console.WriteLine("Enter your base");
                triangle.base1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your height");
                triangle.height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your length 1");
                triangle.length1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your length 2");
                triangle.lenght2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The area of the triangle is: ");
                Console.WriteLine(triangle.getArea());
                Console.WriteLine("The Perimeter of the triangle is: ");
                Console.WriteLine(triangle.getPerimeter());
            }
            else
            {
                Console.WriteLine("Thank you, goodbye!");
            }


        }
    }
}
