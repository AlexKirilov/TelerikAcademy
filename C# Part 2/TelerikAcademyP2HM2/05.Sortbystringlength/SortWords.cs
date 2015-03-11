using System;
using System.Linq;
/*Problem 5. Sort by string length

You are given an array of strings.
Write a method that sorts the array by the length of its elements (the number of characters composing them)*/

namespace _05.Sortbystringlength
{
    class SortWords
    {
        static void Main()
        {
            Console.WriteLine("Enter words, separated by a comma: ");
            var words = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderByDescending(x => x.Length)
                .ToList();

            words = words.Distinct().ToList();

            foreach (var word in words)
            {
                Console.WriteLine("{0,-6}{1}", word.Length, word);
            }
        }
    }
}
