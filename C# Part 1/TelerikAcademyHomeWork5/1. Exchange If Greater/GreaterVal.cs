using System;
//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values 
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

namespace Solution1
{
    class GreaterVal
    {
        static void Main()
        {
            double a, b;
            Console.WriteLine("Enter double for 'a' and 'b': ");
            Console.Write("a= ");
            bool isADouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nb= ");
            bool isBDouble = double.TryParse(Console.ReadLine(), out b);
            if (isADouble && isBDouble)
            {
                if (a > b)
                {
                    double swap = a; a = b; b = swap;
                }
                Console.WriteLine("A and B are: {0} {1}", a, b);
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
            Main();
        }
    }
}
