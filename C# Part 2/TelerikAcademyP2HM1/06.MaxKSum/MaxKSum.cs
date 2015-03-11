using System;

/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/
namespace _06MaxKSum
{
    class MaxKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            string bestSeq = "";
            int sum = 0;
            int maxSum = int.MinValue;
            int arrayLen = array.Length;
            for (int i = 0; i < arrayLen; i++)
            {
                string currentSeq = "";
                if (i + k > arrayLen)
                {
                    break;
                }
                for (int j = i; j < i + k; j++)
                {
                    sum = sum + array[j];
                    currentSeq = currentSeq + ' ' + array[j];
                }
                if (sum > maxSum)
                {
                    bestSeq = currentSeq;
                    maxSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(bestSeq);
            Console.WriteLine(maxSum);
        }
    }
}
