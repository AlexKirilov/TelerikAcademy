using System;

//Problem 1. Odd or Even Integers
    //Write an expression that checks if given integer is odd or even.
namespace Problem_1
{
    class OddEven
    {
        static void Main()
        {
            Console.WriteLine("Enter value: \n");
            int x = Console.Read();
            //Cheking the value if is Odd or Even and Print on the console
            if (x % 2 == 0)
                Console.WriteLine("The value is even \n");
            else 
                Console.WriteLine("The value is Odd \n");

            Console.Read(); // For not closing the console
        }
    }
}
