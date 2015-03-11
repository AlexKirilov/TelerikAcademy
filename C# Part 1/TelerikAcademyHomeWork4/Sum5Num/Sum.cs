using System;

//Problem 7. Sum of 5 Numbers
//    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
namespace Sum5Num
{
    class Sum
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers with space between them");
            string eVal = Console.ReadLine();
            if (eVal.Length > 4)
            {
                string[] realVal = eVal.Split(' ');
                double res = 0;
                foreach (string word in realVal)
                {
                    double Val = Convert.ToDouble(word);
                    res += Val;
                }
                Console.WriteLine("\nSum is: " + res + "\n");
            }
            else
            {
                Console.WriteLine("\nBad Input \n");
            }
            Main();//Recursive function
        }
    }
}
