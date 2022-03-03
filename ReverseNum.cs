using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_PracticeProblems
{
    public class ReverseNum
    {
        public void ReverseNumMethod(int userinput)
        {
            int num;
            Console.WriteLine("Enter a Number to reverse: ");
            num = Convert.ToInt32(Console.ReadLine());
            int Reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                Reverse = (Reverse * 10) + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
        }
    }
}
