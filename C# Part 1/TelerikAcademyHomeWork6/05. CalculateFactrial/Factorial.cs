using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//  Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//  Use only one loop. Print the result with 5 digits after the decimal point.

namespace CalculateFactrial
{
    class Factorial
    {
        static void Main()
        {
            int n, x, factorial = 1;
            double sum = 1;
            Console.WriteLine("Enter two integer numbers 'n' and 'x':");
            Console.Write("n = ");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("\nx = ");
            bool isXInt = int.TryParse(Console.ReadLine(), out x);
            if (isNInt && isXInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                    sum += (factorial) / Math.Pow(x, i);
                }
                Console.WriteLine("S = {0}", sum.ToString("0.00000"));
            }
            else { Console.WriteLine("Bad input, try again");
            Main(); // Recursive function
            }
        }
    }
}
