using System;


//Problem 13. Binary to Decimal Number

//  Using loops write a program that converts a binary integer number to its decimal form.
//  The input is entered as string. The output should be a variable of type long.
//  Do not use the built-in .NET functionality.

namespace _13.BinarytoDecimalNum
{
    class BinaryToDeci
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary integer to convert to ts decimal form\n");
            Console.Write("n = ");
            string binary = Console.ReadLine();
            char[] arr = binary.ToCharArray();
            long sum = 0;
            long bit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // 101_2 = 1*2^2 + 0*2^1 + 1*2^0 = 5 (five)

                bit = Convert.ToInt64(arr[i]) - 48;
                sum += bit * (long)(Math.Pow(2, (arr.Length - (i + 1))));
            }
            Console.WriteLine("\n"+sum);
        }
    }
}
