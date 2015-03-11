using System;

//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace _16.DeciToHexadecimalNumbers
{
    class DeciToHexi
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string result = "";
            while (input > 0)
            {
                if (input % 16 <= 15 && input % 16 >= 10)
                {
                    switch (input % 16)
                    {
                        case 10:
                            result = "A" + result;
                            break;
                        case 11:
                            result = "B" + result;
                            break;
                        case 12:
                            result = "C" + result;
                            break;
                        case 13:
                            result = "D" + result;
                            break;
                        case 14:
                            result = "E" + result;
                            break;
                        case 15:
                            result = "F" + result;
                            break;
                    }
                }
                else
                {
                    result = Convert.ToString(input % 16) + result;
                }
                input /= 16;
            }
            Console.WriteLine(result);
        }
    }
}
