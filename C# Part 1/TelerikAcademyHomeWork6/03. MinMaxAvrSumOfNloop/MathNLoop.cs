using System;

//Problem 3. Min, Max, Sum and Average of N Numbers

//  Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//  the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//  The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//  The output is like in the examples below.

namespace MinMaxAvrSumOfNloop
{
    class MathNLoop
    {
        static void Main()
        {
            Console.WriteLine("Input the lenght of the sequence from 1 - 9 'x': ");
            Console.Write("Lenght X = ");
            int x, max = 0, min = 0, sum = 0;
            float avg;

            bool isXInt = int.TryParse(Console.ReadLine(), out x);
            //Cheking all valueble for n is it real positive int
            x = Math.Abs(x);
            if (isXInt && x > 0 && x < 10)
            {
                Console.WriteLine("Enter values for n:");
                int[] n = new int [x];
                for (int i = 0; i < x; i++)
                {
                    Console.Write("\nn = ");
                    bool isNInt = int.TryParse(Console.ReadLine(), out n[i]);
                    //Cheking all valueble for n is it real int
                    if (isNInt)
                    {
                        if (i == 0)  {  max = min = n[i]; }
                        else {
                            max = Math.Max(max, n[i]);
                            min = Math.Min(min, n[i]);
                        }
                        sum += n[i];     
                    }
                }
                avg = (float)sum / x;
                Console.WriteLine("\nMax = {0} ", max);
                Console.WriteLine("Min = {0} ", min);
                Console.WriteLine("Sum = {0} ", sum);
                Console.WriteLine("Avg = {0} ", avg.ToString("0.00"));
            }
        }
    }
}
