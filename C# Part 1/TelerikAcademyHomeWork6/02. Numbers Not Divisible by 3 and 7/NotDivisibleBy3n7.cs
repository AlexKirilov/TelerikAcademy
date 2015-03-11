using System;

//Problem 2. Numbers Not Divisible by 3 and 7

//  Write a program that enters from the console a positive integer n 
//  and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

namespace Numbers_Not_Divisible_by_3_and_7
{
    class NotDivisibleBy3n7
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number 'n': ");
            Console.Write("n = ");
            int n;
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            if (isNInt)
            {
                Console.WriteLine("\n"); // Empty row
                n = Math.Abs(n); // Makes n positive
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
            Console.WriteLine("\n"); // Empty row
        }
    }
}
