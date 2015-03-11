using System;
using System.Collections.Generic;
/*
Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	output
.NET	platform for applications from Microsoft
CLR	managed execution environment for .NET
namespace	hierarchical organization of classes
*/
namespace _14.WordDictionary
{
    class Dictionary
    {
        static void Main()
        {
            Console.WriteLine("WORD DICTIONARY");
            Console.Write("\nCheck  for:");
            bool isExist = false;
            string str = Console.ReadLine();

            var dictionary = new Dictionary<string, string>();
            // You can add so many different dictionary words, those are examples:
            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            foreach (var word in dictionary)
            {
                if (word.Key == str)
                {
                    Console.WriteLine("\n{0} is {1}", str, word.Value);
                    isExist = true;
                }
            }
            if (isExist == false) Console.WriteLine("This word doesn`t add in the dictionary");

        }
    }
}
