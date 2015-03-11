using System;
/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	output
C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
 */
namespace _13.Reverse_Sentence
{
    class ReverceSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentence");
            string str = Console.ReadLine();
            if (str.Length < 3) str = "C# is not C++, not PHP and not Delphi!"; //Default sentence
            string symbol = str.Substring(str.Length - 1, 1);
            string[] words = str.Split(' ', ',', '.', '!', '?');
            Console.WriteLine("This is the revers sentence:\n");
            for (int i = words.Length-1; i >= 0; i--)
            {
                Console.Write(words[i]);
                if (i == words.Length - 5) Console.Write(",");
                if (i == 0) Console.Write(symbol + "\n");
                Console.Write(" ");
            }
            
            
        }
    }
}
