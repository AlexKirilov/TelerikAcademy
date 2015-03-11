using System;

//Problem 11. Random Numbers in Given Range

//  Write a program that enters 3 integers n, min and max (min != max)
//  and prints n random numbers in the range [min...max].

namespace _11.RandomNumForN
{
    class RandNumbersMinMax
    {
        static void Main()
        {
            int n, min, max;
            Console.WriteLine("Enter 3 integers for 'n', 'min' and 'max' ");
            Console.Write("n = ");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            Console.Write("\nmin = ");
            bool isMinInt = int.TryParse(Console.ReadLine(), out min);
            Console.Write("\nmax = ");
            bool isMaxInt = int.TryParse(Console.ReadLine(), out max);
            if (isNInt && isMinInt && isMaxInt && min != max)
            {
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    int print = rnd.Next(min, max + 1);
                    Console.Write(print + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }

        }
    }
}
