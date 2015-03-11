using System;

//Problem 16.** Bit Exchange (Advanced)
//  Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//  The first and the second sequence of bits may not overlap.

namespace Bit_ExchangeAdvanced
{
    class BitExchange
    {
        static void Main()
        {
            uint num; // keep the main values
            byte p,q,k;
            Console.WriteLine("Please enter unsignet number \n");
            bool isInt = uint.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("\nPlease enter the start position of first sequence p ");
            bool isPosP = byte.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("\nPlease enter the start position of second sequence q");
            bool isPosQ = byte.TryParse(Console.ReadLine(), out q);
            Console.WriteLine("\nPlease wnter the lenght of the sequence k\n");
            bool isPosK = byte.TryParse(Console.ReadLine(), out k);
            
            //cheking enter value ant posion
            if (isInt && isPosP && isPosQ && isPosK)
            {
                Console.WriteLine("First IF");
                if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
                {
                    Console.WriteLine("Second IF");
                    
                    if (p > q)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    Console.WriteLine("Last IF");
                    string str = Convert.ToString(num, 2).PadLeft(32, '0');
                    char[] bitSym = str.ToCharArray();
                    Console.WriteLine(bitSym);
                    Array.Reverse(bitSym);
                    Console.WriteLine(bitSym);
                    for (int i = p; i < p + k; i++)
                    {

                        bitSym[q] ^= bitSym[i];
                        bitSym[i] ^= bitSym[q];
                        bitSym[q] ^= bitSym[i];

                        q++;
                    }
                    Array.Reverse(bitSym);
                    string s = new string(bitSym);
                    long result = Convert.ToInt64(s, 2);
                    Console.WriteLine(s);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Bad input. Please try again");
                }
            }
            else
            {
                //Console.WriteLine("\n" + Convert.ToString(bitVal, 2).PadLeft(32, '0') + "\n");
                Console.WriteLine("Bad input. Please try again");
            }
            //Recursive function
            Main();      
        }
    }
}
