using System;

//Problem 9. Matrix of Numbers

//  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
//  and prints a matrix like in the examples below. Use two nested loops.

namespace _09.MatrixOfNumbers
{
    class Matric
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a positive integer 'n' (1 ≤ n ≤ 20) to create a matrix");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            // if n is negative number
            if (n < 0)  {    n *= -1; }

            if (isNInt && 1<= n && n <= 20)
            {
                //Console.WriteLine("matrix");
                for (int i = 0; i < n; i++)
                {
                    for (int y = 1; y <= n; y++)
                    {
                        if (y + i > 9)
                        {
                            Console.Write("{0} ", y + i);
                        }
                        else
                        {
                            Console.Write("{0}  ", y + i);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
        }
    }
}
