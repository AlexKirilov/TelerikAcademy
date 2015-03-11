using System;
/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	\u0048\u0069\u0021*/
namespace _10.Unicode_characters
{
    class UniCodeChar
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Console.WriteLine("Result in Unicode characters:\n");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0}", ((int)input[i]).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}
