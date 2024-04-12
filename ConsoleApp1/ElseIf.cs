using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ElseIf
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning");
            }
            else if (time < 23)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}
