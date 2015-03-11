using System;
/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.*/

namespace _09.Frequentnumber
{
    class FrequentNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int frequency = 0;
            int maxFrequency = 0;
            int value = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequency++;
                    }
                    if (frequency > maxFrequency)
                    {
                        maxFrequency = frequency;
                        value = array[i];
                    }
                }
                frequency = 0;
            }
            Console.WriteLine("{0} ({1} times)", value, maxFrequency);
        }
    }
}
