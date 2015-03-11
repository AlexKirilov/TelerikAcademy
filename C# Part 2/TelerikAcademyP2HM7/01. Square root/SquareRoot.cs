using System;
/*Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.*/
namespace _01.Square_root
{
    class SquareRoot
    {
        static void Main()
        {
            int val;
            double result = 0;
            try
            {
                Console.WriteLine("Enter an integer value");
                val = int.Parse(Console.ReadLine());
                if (val >= 0)
                {
                    result = Math.Sqrt(val);
                    Console.WriteLine("Square root of {0}  =  {1}", val, result);
                }
                else throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number.\n\n {0}", ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number. {0}", ex);
            }
            finally
            {
                Console.WriteLine("\n\nGOODBAY");
            }
        }
    }
}
