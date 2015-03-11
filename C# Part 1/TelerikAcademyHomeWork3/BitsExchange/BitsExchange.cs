using System;

//Problem 15.* Bits Exchange
//  Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            uint bitVal; // keep the main values
            int b = 24;
            Console.WriteLine("Please enter value \n");
            bool isvInt = uint.TryParse(Console.ReadLine(), out bitVal);
            Console.WriteLine("\n" + Convert.ToString(bitVal, 2).PadLeft(32, '0') + "\n");
            string value = Convert.ToString(bitVal, 2).PadLeft(32, '0');
            //cheking enter value ant posion
            if (isvInt)
            {  
                char[] bitSym = value.ToCharArray();
                Array.Reverse(bitSym);
                for (int i = 3; i < 6; i++) {
                    
                    bitSym[b] ^= bitSym[i];
                    bitSym[i] ^= bitSym[b];
                    bitSym[b] ^= bitSym[i];

                    b++;     
                }
                Array.Reverse(bitSym);
                string s = new string(bitSym);
                long result = Convert.ToInt64(s,2);
                Console.WriteLine(s);
                Console.WriteLine(result);
            }
            else{
                Console.WriteLine("Bad input. Please try again");
            }
            //Recursive function
            Main();      
        }
    }
}
