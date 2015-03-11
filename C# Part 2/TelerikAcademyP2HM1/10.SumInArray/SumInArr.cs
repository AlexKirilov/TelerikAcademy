using System;
/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).*/

namespace _10.SumInArray
{
    class SumInArr
    {
        static void Main(string[] args)
        {
             int k = 0;
        int NumOfSums = 0;
        int sum = 0;
        int start = 0;
        int end = 0;
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the searched sum: ");
        int s = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Please enter the {0} index ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The searched elements are: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j < n)
                {
                    sum = sum + array[i + j];
                    if (sum == s)
                    {
                        start = i;
                        end = i + j;
                        NumOfSums++;
                        for (k = start; k <= end; k++)
                        {
                            Console.Write("{0}; ", array[k]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            sum = 0;
        }

        }
    }
}
