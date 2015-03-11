using System;

//Problem 7. Sort 3 Numbers with Nested Ifs

//  Write a program that enters 3 real numbers and prints them sorted in descending order.
//  Use nested if statements.
//  Note: Don’t use arrays and the built-in sorting functionality.

namespace Sort_3_NumbersWithNestedIfs
{
    class NestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Enter three digits");
            double a, b, c;
            Console.Write("\na = ");
            bool isADouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nb = ");
            bool isBDouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("\nc = ");
            bool isCDouble = double.TryParse(Console.ReadLine(), out c);
            //Checking for valid entry
            if (isADouble && isBDouble && isCDouble)
            {
                if      (a >= c && a >= b && b >= c) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", a, b, c); }
                else if (a >= c && a >= b && b <= c) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", a, c, b); }
                else if (b >= a && b >= c && a >= c) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", b, a, c); }
                else if (b >= a && b >= c && a <= c) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", b, c, a); }
                else if (c >= a && c >= b && a >= b) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", c, a, b); }
                else if (c >= a && c >= b && a <= b) { Console.WriteLine("\nThe numbers are sorted \n {0} , {1} , {2} ", c, b, a); }
            }
            else { Console.WriteLine("Bad input, try again"); }
            Main(); // Recursive function
        }
    }
}
