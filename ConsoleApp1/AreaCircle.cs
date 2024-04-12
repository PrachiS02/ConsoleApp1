using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AreaCircle
    {
        static void Main(string[] args)
        {
            double r, area;

            Console.WriteLine("Enter the radius ");
            r=Convert.ToDouble(Console.ReadLine());

            area = (3.14 * r * r);

            Console.WriteLine("Area of Circle " + area);
        
        }
    }
}
