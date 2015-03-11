using System;
/*Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.*/

namespace _08.MaxSum
{
    class MaxSum
    {
        static void Main()
        {
            Console.Write("Please enter the length of array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of sequence: ");
            int sequence = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Please enter element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (i >= sequence - 1)
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        start = i - (sequence - 1);
                        end = start + sequence;
                    }
                    sum -= array[i - (sequence - 1)];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maximal sum is: {0}", maxSum);
            Console.WriteLine("Sequence with maximal sum is: ");
            Console.Write('{');
            for (int i = start; i < end; i++)
            {
                Console.Write(array[i]);
                if (i < end - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
