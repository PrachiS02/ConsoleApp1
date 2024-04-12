using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number1");
            int a = Convert.ToInt32(Console.ReadLine());  
            
                if (a % 2 == 0)
                {
                    Console.WriteLine($" {a} number is even ");
                        
                        
                }
                else
                { 
                    Console.WriteLine($" {a} number is odd ");
                
                }
            

        }
    }
}
