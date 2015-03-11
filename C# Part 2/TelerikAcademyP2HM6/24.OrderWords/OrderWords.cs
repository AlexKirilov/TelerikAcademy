using System;
/*
 Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/
namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text to order the words alphabetic");
            string text = Console.ReadLine();
            string[] letters = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(letters);
            Console.WriteLine(String.Join("\n", letters));
        }
    }
}
