using System;

//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

namespace Bitwise
{
    class ExtractBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter some value");
            uint bitVal;
            int p = 3; //position
            bool isvInt = uint.TryParse(Console.ReadLine(), out bitVal);
            //cheking enter val
            if (isvInt)
            {
                int bit = (int)(bitVal >> p) & 1;
                Console.WriteLine("The bit in position #{0} of number {1} is: {2}", p, bitVal, bit);
            }
            else { 
                Console.WriteLine("Bad input. Please try again");
            }
            //Recursive function
            Main();
        }
    }
}
