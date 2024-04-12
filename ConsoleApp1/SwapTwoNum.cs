using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SwapTwoNum
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Enter the First Number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("Second Number : " + num2);
           

        }
    }
}
