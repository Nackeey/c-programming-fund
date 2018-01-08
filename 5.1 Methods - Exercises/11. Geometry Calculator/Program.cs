using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",TriangleArea(side, height));
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",SquareArea(side));
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",RectangleArea(width, height));
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",CircleArea(radius));
            }
        }

        static double TriangleArea(double side, double height)
        {
            double result = side * height / 2;
            return result;
        }

        static double SquareArea(double side)
        {
            double result = side * side;
            return result;
        }

        static double RectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }

        static double CircleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }
    }
}
