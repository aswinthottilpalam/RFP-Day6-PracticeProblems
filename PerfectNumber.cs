using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_PracticeProblems
{
    public class PerfectNumber
    {
        public void PerfectNumberMethod(int userinput)
        {
            int num, sum = 0;
            Console.Write("enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(" Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");
            }
        }
    }
}
