using System;

//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace _15.HexyToDecimalNumbers
{
    class HexiToDeci
    {
        static void Main()
        {
            
            string hexInput = Console.ReadLine();
            char[] chars = hexInput.ToCharArray();
            long[] sums = new long[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case 'A':
                        sums[i] = 10 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case 'B':
                        sums[i] = 11 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case 'C':
                        sums[i] = 12 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case 'D':
                        sums[i] = 13 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case 'E':
                        sums[i] = 14 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case 'F':
                        sums[i] = 15 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '0':
                        sums[i] = 0 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '1':
                        sums[i] = 1 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '2':
                        sums[i] = 2 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '3':
                        sums[i] = 3 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '4':
                        sums[i] = 4 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '5':
                        sums[i] = 5 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '6':
                        sums[i] = 6 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '7':
                        sums[i] = 7 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '8':
                        sums[i] = 8 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                    case '9':
                        sums[i] = 9 * ((long)Math.Pow(16, chars.Length - (i + 1)));
                        break;
                }
            }
            long result = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                result += sums[i];
            }
            Console.WriteLine(result);
        }
    }
}
