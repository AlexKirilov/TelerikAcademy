using System;
/*Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/

namespace _15.PrimeNumber
{
    class PrimeNum
    {
        static void Main(string[] args)
        {
            bool[] array = new bool[10000001];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(array.Length); i++)
            {

                if (array[i])
                {
                    for (int j = i * i; j < array.Length; j += i)
                    {
                        array[j] = false;
                    }
                }


            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
