using System;
using System.Numerics;

//Problem 18.* Trailing Zeroes in N!

//  Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//  Your program should work well for very big numbers, e.g. n=100000.

namespace _18.TrailingZeroesInN
{
    class TrailingZero
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger facturial = 1;
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                facturial *= i;
            }
            Console.WriteLine(facturial);
            for (int i = 0; i <= facturial; )
            {
                if (facturial % 10 == 0)
                {
                    facturial /= 10;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
