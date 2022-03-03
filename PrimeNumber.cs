using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_PracticeProblems
{
    public class PrimeNumber
    {
        public void PrimeNumberMethod(int userinputs)
        {
            int i, num;
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} This number is not a Prime number");
                }
                else
                {
                    Console.WriteLine($"{num} This number is a Prime number");
                }
            }
        }
    }
}
