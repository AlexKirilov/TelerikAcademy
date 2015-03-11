using System;

//Problem 14. Modify a Bit at Given Position

//  We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//  Write a sequence of operators (a few lines of C# code) that modifies n 
//  to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
namespace ModifyBitAtGivenPosition
{
    class ModifyBit
    {
        static void Main()
        {
            int bitVal; // keep the main values
            byte p; //position
            byte v; // 0 or 1

            Console.WriteLine("Please enter value");
            bool isvInt = int.TryParse(Console.ReadLine(), out bitVal);
            Console.WriteLine("enter the position");
            bool isPos = byte.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("enter the digit 0 or 1 ");
            bool isV = byte.TryParse(Console.ReadLine(), out v);
            //cheking enter value ant posion
            if (isvInt && isPos && isV && v < 2 && p < 32)
            {
                if (v == 0 || v == 1) {
                    byte[] intBytes = BitConverter.GetBytes(bitVal);
                    int mask = 1 << p;
                    if (v == 1)
                    {
                        bitVal = bitVal | mask;
                    }
                    else
                    {
                        if ((bitVal & mask) == mask)
                        {
                            bitVal = bitVal ^ mask;
                        }
                    }
                    int bit = (int)(bitVal >> p) & 1; // To print the bit
                    
                    //Print into the Console
                    Console.WriteLine("The bit in position #{0} is {1} ", p, bit );
                    Console.WriteLine("Changing the bit {0} with {1}" , bit,v);
                    Console.WriteLine("The new number is: {0}", bitVal);
                }
                else
                {
                    Console.WriteLine("Bad input on V. Please try again");
                    Main();//Recursive function
                }
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
