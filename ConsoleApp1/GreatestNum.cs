using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GreatestNum
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the Two Numbers : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is the Greatest Number", a);
            }
            else
            {
                Console.WriteLine("{0} is the Greatest Number ", b);
            }
        }
    }
}
