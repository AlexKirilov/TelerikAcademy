using System;

//Problem 1. Numbers from 1 to N

//  Write a program that enters from the console a positive integer n
//  and prints all the numbers from 1 to n, on a single line, separated by a space.

namespace pr1
{
    class From1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter n to print from 1 ... n");
            Console.Write("n = ");
            int n;
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            if (isNInt)
            {
                Console.WriteLine("\n ");//Empty row
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else { Console.WriteLine("Bad input, try again"); }
            Console.WriteLine("\n "); // Empty row
        }
    }
}
