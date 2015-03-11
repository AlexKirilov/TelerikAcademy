using System;

//Problem 6. The Biggest of Five Numbers
//  Write a program that finds the biggest of five numbers by using only five if statements.

namespace The_Biggest_of_Five_Numbers
{
    class BiggestOf5
    {
        static void Main()
        {
            Console.WriteLine("Enter three digits");
            double a, b, c ,d , e;
            Console.Write("\na = ");
            bool isADouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nb = ");
            bool isBDouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("\nc = ");
            bool isCDouble = double.TryParse(Console.ReadLine(), out c);
            Console.Write("\nd = ");
            bool isDDouble = double.TryParse(Console.ReadLine(), out d);
            Console.Write("\ne = ");
            bool isEDouble = double.TryParse(Console.ReadLine(), out e);
            //Checking for valid entry
            if (isADouble && isBDouble && isCDouble && isDDouble && isEDouble)
            {
                double max = Math.Max(a, b);
                max = Math.Max(max, c);
                max = Math.Max(max, d);
                if (max > e) { Console.WriteLine("The biggest from five numbers is {0} ", max); }
                else { Console.WriteLine("The biggest from five numbers is {0} ", e); }
            }
            else { Console.WriteLine("Bad input, try again"); }
            Main(); // Recursive function
        }
    }
}
