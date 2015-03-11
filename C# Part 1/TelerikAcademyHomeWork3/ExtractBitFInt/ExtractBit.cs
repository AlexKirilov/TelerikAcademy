using System;

//Problem 12. Extract Bit from Integer
//    Write an expression that extracts from given integer n the value of given bit at index p.

namespace ExtractBitFInt
{
    class ExtractBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter some value");
            int bitVal;
            int p ; //position
            bool isvInt = int.TryParse(Console.ReadLine(), out bitVal);
            Console.WriteLine("enter the position");
            bool isPos = int.TryParse(Console.ReadLine(), out p);
            //cheking enter value ant posion
            if (isvInt && isPos) {
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
