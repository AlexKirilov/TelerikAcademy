using System;
using System.Collections.Generic;

//Problem 12.* Randomize the Numbers 1…N

//  Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

namespace _12.RandomizeNumbers
{
    class RandNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter value for 'n' to print all digits from 1 .. n - randomly");
            int n;
            Console.Write("n = ");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            if (isNInt)
            {
                int[] array = new int[n];
                for (int index = 0; index < n; index++)
                {
                    array[index] = index + 1;
                }

                Random random = new Random();
                foreach (int index in array)
                {
                    int randNum = random.Next(0, n);
                    int temp = array[randNum];
                    array[randNum] = array[0];
                    array[0] = temp;
                }
                Console.WriteLine(String.Join(" ", array));
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
        }
    }
}
