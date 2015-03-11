using System;
/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	output
aaaaabbbbbcdddeeeedssaa	abcdedsa*/
namespace _23.SeriesOfLetter
{
    class SeriesOfLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string str = "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    continue;
                }
                else if (input[i] != input[i + 1])
                {
                    str += input[i];
                }
            }
            Console.WriteLine(str + input[input.Length - 1]);
        }
    }
}
