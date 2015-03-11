using System;

//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
namespace ConsoleApplication2
{
    class CompareNum
    {
        static void Main()
        {
            double a, b;
            Console.Write("Enter the first number a: ");
            bool isA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b: ");
            bool isB = double.TryParse(Console.ReadLine(), out b);
            if (isA & isB)
            {
                Console.WriteLine("The greater number is: {0} ", Math.Max(a, b));
            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }
    }
}
