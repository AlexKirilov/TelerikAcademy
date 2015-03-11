using System;
/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().*/

namespace _02GetLaergestNumber
{
    class LargestNum
    {
        static int GetMax(int x, int y)
        {
            return Math.Max(x, y); 
        }
        static void Main()
        {
            Console.WriteLine("Please enter digits for :");
            int a, b, c;
            Console.Write("a = "); bool isAInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("b = "); bool isBInt = int.TryParse(Console.ReadLine(), out b);
            Console.Write("c = "); bool isCInt = int.TryParse(Console.ReadLine(), out c);
            if (isAInt && isBInt && isCInt)
            {
                int max = GetMax(a, b);
                max = GetMax(max, c);
                Console.WriteLine("\nThe Largest of those three digits is MAX = {0}", max);
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
        }
    }
}
