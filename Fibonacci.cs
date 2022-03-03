using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_PracticeProblems
{
    public class Fibonacci
    {
        public void FibonacciMethod(int userinput)
        {
            int num1 = 0, num2 = 1, nextNum, i, n;
            Console.Write("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");

            for (i = 2; i < n; i++)
            {
                nextNum = num1 + num2;
                Console.Write(nextNum + " ");
                num1 = num2;
                num2 = nextNum;
            }
        }
    }
}
