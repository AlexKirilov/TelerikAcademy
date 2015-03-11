using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            int counter = 0;
            Console.WriteLine("Enter some text with brackets");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            foreach (char val in charArray)
            {
                if (val == '(') counter++;
                if (val == ')') counter--;
            }
            if (counter != 0) Console.WriteLine("Expression is incorrect");
            else Console.WriteLine("Expression is correct");

        }
    }
}
