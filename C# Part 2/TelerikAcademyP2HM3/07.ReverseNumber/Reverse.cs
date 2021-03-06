﻿using System;
using System.Text;
/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.*/

namespace _07.ReverseNumber
{
    class Reverse
    {
        static void Main()
        {
            Console.WriteLine("Please enter a decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = ReverseNumber(number);

            Console.WriteLine(reversedNumber);
        }

        // It works with pointing-float numbers too.
        private static decimal ReverseNumber(decimal number)
        {
            StringBuilder reversed = new StringBuilder();
            string numberAsString = number.ToString();
            for (int i = 0; i < numberAsString.Length; i++)
            {
                reversed.Append(numberAsString[numberAsString.Length - 1 - i]);
            }

            decimal reversedNumber = decimal.Parse(reversed.ToString());
            return reversedNumber;
        }
    }
}
