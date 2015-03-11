using System;

/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/
namespace _09.ForbiddenWord
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter some text");
            string str = Console.ReadLine();
            Console.WriteLine("\nEnter the forbiddend words");
            string forbWord = Console.ReadLine();

            //Default values
            if (str.Length < 10)        { str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR."; }
            if (forbWord.Length == 0)   { forbWord = "PHP, CLR, Microsoft"; }
            string[] fW = forbWord.Split(','); // foreach forbidden word
            string[] sentence = str.Split('.');
            
            int wordSize = 0;
            char symbol = '*';
            for (int s = 0; s < sentence.Length -1; s++)
            {
                string[] words = sentence[s].Split(' '); //foreache word.
                //checking the words
                for (int w = 0; w < words.Length; w++)
                {
                    //for forbidden words
                    for (int i = 0; i < fW.Length; i++)
                    {
                        if (words[w] == fW[i].Trim())
                        {
                            wordSize = words[w].Length;
                            words[w] = "";//delete the word and exchange it with *
                            words[w] = words[w].PadRight(wordSize, symbol);
                        }
                    }
                    Console.Write(" " + words[w]);
                }
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}
