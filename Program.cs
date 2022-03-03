using System;

namespace RFP_Day6_PracticeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Fibonacci f = new Fibonacci();
            f.FibonacciMethod(n);

        }
    }
}
