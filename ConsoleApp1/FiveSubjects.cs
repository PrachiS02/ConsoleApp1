using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FiveSubjects
    {
        static void Main(string[] args)
        {
            double tm = 0,per;
            for (int i = 1; i <=5; i++) 
            {
                Console.WriteLine("Enter Five Subject Marks:" +i+ ":");
                tm += Convert.ToDouble(Console.ReadLine());

            }
            per=(tm/500)*100;
            Console.WriteLine("Percentage of Five Subjects:"+per+"%");
        }
    }
}
