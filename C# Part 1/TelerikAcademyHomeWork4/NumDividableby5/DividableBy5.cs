using System;
using System.Collections.Generic;

//Problem 11.* Numbers in Interval Dividable by Given Number

//  Write a program that reads two positive integer numbers and prints how many numbers p
//  exist between them such that the reminder of the division by 5 is 0.
namespace NumDividableby5
{
    class DividableBy5
    {
        static void Main()
        {
            int x, y, p = 0, i = 0; // i - index; p - counting digits;
            List<int> res = new List<int>();
            Console.WriteLine("Enter start X and the end Y Positive integer");
            Console.Write("\nX = ");
            bool isX = int.TryParse(Console.ReadLine(), out x);
            Console.Write("\nY = ");
            bool isY = int.TryParse(Console.ReadLine(), out y);
            if (isX && isY)
            {
                //chek if X is bigger than Y - Swap function
                if (x > y) { int swap = x; x = y; y = swap; }
                for (; x <= y; x++)
                {
                    if (x % 5 == 0) { res.Add(x); p++; i++; }
                }
                Console.Write(" There are {0} numbers: ",p);
                foreach (int print in res){
                    Console.Write(", {0} ", print);
                }
                Console.WriteLine(" \n ");
            }
            else
            {
                Console.WriteLine("\n Bad input, try again \n");
            }
            Main(); // recursive function
        }
    }
}
