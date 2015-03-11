using System;

//Problem 1. Sum of 3 Numbers
//  Write a program that reads 3 real numbers from the console and prints their sum.
namespace Solution1
{
    class SumNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter three real numbers");
            int a, b, c, result;
            bool isA = int.TryParse(Console.ReadLine(), out a);
            bool isB = int.TryParse(Console.ReadLine(), out b);
            bool isC = int.TryParse(Console.ReadLine(), out c);

            if (isA && isB && isC)
            {
                result = a + b + c;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Bad input");
            }
            //Recursive function
            Main();
        }

    }
}
