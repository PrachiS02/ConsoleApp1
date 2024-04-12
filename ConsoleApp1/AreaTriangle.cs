using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AreaTriangle
    {
        static void Main(string[] args)
        {
            double length, height, area;
            Console.WriteLine("Enter the base" );
            length = double.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the heigth");
            height = double.Parse(Console.ReadLine());
            area = (length * height) / 2;

            Console.WriteLine("Area of Triangle " +area);


        }
    }
}
