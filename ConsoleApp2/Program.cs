using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
 
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter lenth of rectangle");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("enter width of rectangle");
                double width = double.Parse(Console.ReadLine());
                double area = Area(length, width);
                Console.WriteLine("Area is :" + area);

            }
            static double Area(double length, double width)
            {
                return length * width;
            }
        }
    }
