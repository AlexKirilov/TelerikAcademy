using System;

//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

namespace nNumbers
{
    class PrintNum
    {
        static void Main()
        {
            int n;
            Console.Write("Enter the sequance n=  ");
            bool intN = int.TryParse(Console.ReadLine(), out n);
            if (intN)  {
                for (int i = 1; i <= n; i++) {
                    Console.WriteLine(i);
                }
            }  else {
                Console.WriteLine("Bad input");
            }
            Main();
        }
    }
}
