using System;
/*
 * Problem 9. Exchange Variable Values

        Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        Print the variable values before and after the exchange.
 */
namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, swap;
            Console.WriteLine("a = " + a + "   b = " + b);
            
            //exchange logic
            swap = a;
            a = b;
            b = swap;

            Console.WriteLine("a = " + a + "  b = " + b);

        }
    }
}
