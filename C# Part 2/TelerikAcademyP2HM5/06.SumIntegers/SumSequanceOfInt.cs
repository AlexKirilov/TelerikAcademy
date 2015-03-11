using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	output
"43 68 9 23 318"	461
 */
namespace _06.SumIntegers
{
    class SumSequanceOfInt
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer numbers, separated by space: ");
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(nums.Sum());
        }
    }
}
