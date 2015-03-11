using System;

//Problem 9. Sum of n Numbers
//  Write a program that enters a number n and after that enters more n numbers
//  and calculates and prints their sum. Note: You may need to use a for-loop.

namespace SumOfNNum
{
    class Program
    {
        static void Main()
        {
            int n, N;
            Console.Write("Specify what should be the sequence of input numbers n: ");
            bool isN = int.TryParse(Console.ReadLine(), out n);
            N = n;
            if (isN)
            {
                double val = 0, res = 0;
                Console.WriteLine("Enter the {0} numbers int the console: \n", n);
                for (int i = 1; i <= n; i++)
                {
                    bool isVal = double.TryParse(Console.ReadLine(), out val);
                    if (isVal)
                    {
                        res += val;
                    }
                    else
                    {
                        Console.WriteLine("Bad input, try again");
                        n++;
                    }
                }
                Console.WriteLine("\nThe sum of the {0} numbers are:  {1}\n", N, res);
            }
            else
            {
                Console.WriteLine("\nBad input, try again\n");
            }
            Main();
        }
    }
}
