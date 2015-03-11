using System;
/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("The length of the array = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Search for a number = ");
            int search = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            int min = 0;
            int max = array.Length - 1;
            int middle = 0;

            while (min <= max)
            {
                middle = (max + min) / 2;
                if (array[middle] < search)
                {
                    min = middle + 1;
                }
                else if (array[middle] > search)
                {
                    max = middle - 1;
                }
                else
                {
                    break;
                }
            }
            if (array[middle] == search)
            {
                Console.WriteLine("The searched number {0} was found at position {1}", search, middle);
            }
            else
            {
                Console.WriteLine("The searched number {0} was not present in the array", search);
            }
        }
    }
}
