using System;

//Problem 17.* Calculate GCD

//  Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//  Use the Euclidean algorithm (find it in Internet).

namespace _17.Calculate_GCD
{
    class CalcGCD
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the values for 'a' and 'b' to calculate the greatest common divisor (GCD) ");
            Console.Write("a = ");  bool isAInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");  bool isBInt = int.TryParse(Console.ReadLine(), out b);
            if (isAInt && isBInt && a > b)
            {
                int remain = a % b;
                while (remain != 0)
                {
                    a = b;
                    b = remain;
                    remain = a % b;
                }
                Console.WriteLine(Math.Abs(b));
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }

        }
    }
}
