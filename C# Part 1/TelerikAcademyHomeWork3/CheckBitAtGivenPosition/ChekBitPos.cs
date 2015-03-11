using System;
//Problem 13. Check a Bit at Given Position
//  Write a Boolean expression that returns if the bit at position p 
//  (counting from 0, starting from the right) in given integer number n, has value of 1.
namespace CheckBitAtGivenPosition
{
    class ChekBitPos
    {
        static void Main()
        {
            Console.WriteLine("Please enter some value");
            int bitVal;
            int p; //position
            bool isvInt = int.TryParse(Console.ReadLine(), out bitVal);
            Console.WriteLine("enter the position");
            bool isPos = int.TryParse(Console.ReadLine(), out p);
            //cheking enter value ant posion
            if (isvInt && isPos)
            {
                int bit = (int)(bitVal >> p) & 1;
                bool isOne;
                if (bit == 1) { isOne = true; }
                else { isOne = false; }
                Console.WriteLine("The bit in position #{0} is {1} and is  == 1: {2}", p, bit, isOne);
            }
            else
            {
                Console.WriteLine("Bad input. Please try again");
            }
            //Recursive function
            Main();
        }
    }
}
