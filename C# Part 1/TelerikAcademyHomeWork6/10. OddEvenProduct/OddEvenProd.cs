using System;


//Problem 10. Odd and Even Product

//  You are given n integers (given in a single line, separated by a space).
//  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//  Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace _10.OddEvenProduct
{
    class OddEvenProd
    {
        static void Main()
        {
            Console.WriteLine("enter values in a single line, separated by a space");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int oddSum = 1;
            int evenSum = 1;
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (count % 2 == 1)
                {
                    oddSum *= Convert.ToInt32(numbers[i]);
                }
                else
                {
                    evenSum *= Convert.ToInt32(numbers[i]);
                }
                count++;
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddSum);
            }
            if (oddSum != evenSum)
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddSum);
                Console.WriteLine("even_product = {0}", evenSum);
            }
        }
    }
}
