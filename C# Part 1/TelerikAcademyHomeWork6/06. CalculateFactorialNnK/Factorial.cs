using System;

//Problem 6. Calculate N! / K!

//  Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//  Use only one loop.

namespace CalculateFactorialNnK
{
    class Factorial
    {
        static void Main()
        {
            int n, k, result, facturiel1, facturiel2;
            Console.WriteLine("Enter value for n! and k! (1 < k < n < 100) ");
            Console.Write("n = ");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("\nk = ");
            bool isKInt = int.TryParse(Console.ReadLine(), out k);
            if (isNInt && isKInt && 1 < k && k < n  && n < 1000)
            {
                facturiel1 = 1;
                facturiel2 = 1;

                for (int i = 1; i <= n; i++)
                {
                    facturiel1 *= i;
                   
                    //Console.WriteLine( " n = {0} k = {1} ", n, k );
                }
                for (int i = 1; i <= k; i++)
                {
                    facturiel2 *= i; // Calculating factorial function
                }
                result = facturiel1 / facturiel2;
                Console.WriteLine("Result = {0}", result);
            }
            else
            {
                Console.WriteLine("Bad input, try again");
                Main(); // Recursive function
            }
        }
    }
}
