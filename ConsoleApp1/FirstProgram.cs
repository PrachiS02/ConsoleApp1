using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number2");
            int b=Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"addition is {c}");
        }
    }
}
