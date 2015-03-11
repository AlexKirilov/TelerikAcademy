using System;

/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.*/

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int position = 0;
            while (position <= array.Length - 1)
            {
                int min = int.MaxValue;
                for (int i = position; i < array.Length; i++)
                {
                    if (array[i] <= min)
                    {
                        min = array[i];
                    }
                }
                int temp = array[position];
                int minIndex = Array.IndexOf(array, min);
                array[position] = min;
                array[minIndex] = temp;
                position++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
