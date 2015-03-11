using System;
using System.Linq;
/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/
namespace _20.Palindromes
{
    class Palindromes
    {
        
        static void Main()
        {
            Console.WriteLine("Enter different words:\n");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ',', ' ', '.', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int counter = 0;
            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(" - " + word);
                    counter++;
                }
            }
            Console.WriteLine(counter == 0? "There aren`t palindromes in the text!" : "Those are the palindromes from the text" );

        }
        static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
    }
}
















        //static void Main()
        //{
        //    Console.WriteLine("Enter some text to check for Palindromes");
        //    string str = "Some words: exe, rar, ABBA, zaio, bayo, petio, gosho, hahah, xixix.";
        //    string[] words = str.Split(' ');
        //    int counter = 0;
        //    foreach (string word in words)
        //    {
        //        Console.WriteLine("I was here 11111111");
        //        if (IsPalindrome(word))
        //        {
        //            Console.WriteLine("I was here 222222");
        //            Console.WriteLine("This word is Palindrom: {0}", word);
        //            ++counter;
        //        }
        //    }
        //    if (counter == 0) Console.WriteLine("There aren`t palindroms in the text");
        //}
        //public static bool IsPalindrome(string str)
        //{

        //    bool isA = str.SequenceEqual(str.Reverse());
        //    Console.WriteLine(isA + " ssss");
        //    return str.SequenceEqual(str.Reverse());
            
        //}