using System;

//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace _14.DecimalToBinaryNum
{
    class DeciToBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number to convert to its binary representation");
            Console.Write("n = ");
            int input = int.Parse(Console.ReadLine());
            string binary = "";
            for (int i = 0; i < input;)
            {
                if (input%2 == 0)
                {
                    binary += "0"; 
                    input /= 2;

                }
                else
                {
                    binary += "1";
                    input /= 2;
                }
            }
            char[] reverse = binary.ToCharArray();
            Console.WriteLine();
            for (int i = reverse.Length-1; i >= 0; i--)
            {
                Console.Write(reverse[i]);
            }
            Console.WriteLine();
        }
    }
}
