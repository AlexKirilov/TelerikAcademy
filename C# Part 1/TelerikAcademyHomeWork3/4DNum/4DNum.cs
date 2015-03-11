using System;
/*
 Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
 */
namespace _4DNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter four digit number \n");
            //Read from the console
            int number = int.Parse(Console.ReadLine());

            if (Math.Abs(number) <= 9999)
            {
                int a = ((number / 1000) % 10);    //first
                int b = ((number / 100) % 10);     //second
                int c = ((number / 10) % 10);      //third 
                int d = number % 10;               //four 

                //Print to console the result
                Console.WriteLine("\nSum  --> " + (a + b + c + d));
                if (d != 0)
                {
                    Console.WriteLine("Swap --> {0}{1}{2}{3}", d, c, b, a);
                    Console.WriteLine("dabc --> {0}{1}{2}{3}", d, a, b, c);
                }
                else Console.WriteLine("Error, number start with 0. Try again");
                if (a != 0)
                    Console.WriteLine("acbd --> {0}{1}{2}{3}", a, c, b, d);
                else
                    Console.WriteLine("Error, number start with 0. Try again");

            }
            else Console.WriteLine("Bad input. Please try again.");

            Console.Read(); // For not closing the console
        }
    }
}
