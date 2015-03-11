using System;
/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/

namespace _12.IndexOfletters
{
    class IndexOfLetter
    {
        static void Main()
        {
            char[] array = new char[26];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(65 + i);
            }
            Console.Write("Please enter a word of capital letters ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (word[i] == array[j])
                    {
                        Console.Write(j + " ");
                        break;
                    }
                }
            }   
        }
    }
}
