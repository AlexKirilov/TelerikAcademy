using System;
using System.Numerics;

//Problem 8. Catalan Numbers

//  In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//  Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

namespace _08.CatalanaNumbers
{
    class CatalanaNum
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter values for 'n' to calculate the catalan number");
            Console.Write("n! = ");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            BigInteger facturialN = (BigInteger)n;
            BigInteger facturialDoubleN = 2 * facturialN;
            BigInteger facturialNPlusOne = (BigInteger)n + 1;
            if (n < 0) // if n is -n
            {
                n *= -1;
            }
            if (n == 0) { n = 1; Console.WriteLine(n); Main(); }

            if (isNInt && 0 <= n && n <= 100)
            {
                
                //For 2n!
                for (int i = ((2 * n)-1); i > 0; i--)
                {
                    facturialDoubleN *= i;
                }
                //Main cycle
                for (int i = n; i > 0 ; i--)
                {
                    facturialNPlusOne *= i;
                    if (i <= (n - 1))
                    {
                        facturialN *= i;
                    }
                    
                }

                //Calculating the formula n! / (k! * (n-k)!) and printing the result
                BigInteger Cn = facturialDoubleN / (facturialNPlusOne * facturialN);
                Console.WriteLine(Cn);
            }
            else
            {
                Console.WriteLine("Bad input, try again!");
            }
            Main(); // Recursive function
        }
    }
}
