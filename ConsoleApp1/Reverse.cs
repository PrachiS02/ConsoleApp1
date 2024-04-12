using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reverse
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
        }
    }
}
