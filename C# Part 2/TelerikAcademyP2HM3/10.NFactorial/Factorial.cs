using System;
using System.Numerics;
/*Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

namespace _10.NFactorial
{
    class Factorial
    {
        private static BigInteger factorial(int n)
        {
            int counter = n;
            BigInteger factorialNum = 1;
            while(counter > 1)
            {
                factorialNum *= n;
                counter--;
            }
            return factorialNum;
        }

        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                BigInteger result = factorial(i);
                Console.WriteLine("Factorial of {0} =  {1}", i, result);
            }
        }
    }
}
