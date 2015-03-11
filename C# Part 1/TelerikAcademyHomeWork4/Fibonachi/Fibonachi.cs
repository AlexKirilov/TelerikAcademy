using System;

//Problem 10. Fibonacci Numbers
//  Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//  (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Fibonacci fomula Fn = Fn-1 + Fn-2
namespace Fibonachi
{
    class Fibonachi
    {
         static void Main()
        {
            int n;
            Console.Write("Specify what should be the Fibonacci sequence n= ");
            bool isN = int.TryParse(Console.ReadLine(), out n);
            int[] fib = new int[n + 2];
            fib[0] = 0; fib[1] = 1; fib[2] = 1;
            if (isN)
            {
                Console.Write(" Fibonacci: {0}  {1}", fib[0],fib[1]);
                for (int i = 2; i < n; i++ )
                { 
                    fib[i] = fib[i - 1] + fib[i - 2];
                    Console.Write(" {0} ", fib[i]);
                }
            }
            else
            {
                Console.WriteLine("\n Bad input, try again");
            }
            Console.WriteLine("\n");

            Main();
        }
    }
}
