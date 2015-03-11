using System;
using System.Numerics;


//Problem 7. Calculate N! / (K! * (N-K)!)

//  In combinatorics, the number of ways to choose k different members out of a group of n different elements
//  (also known as the number of combinations) is calculated by the following formula: formula For example, 
//  there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//  Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

namespace _07.CalcFacturialFormula
{
    class FormulaFacturiel
    {
        static void Main()
        {
            BigInteger n, k;
            BigInteger facturialN = 1, facturialK = 1, facturialNK = 1;
            Console.WriteLine("Enter values for 'n!' and 'k!' to valvulate the formila n! / (k! * (n-k)!).\nLet the values be between (1 < k < n < 100)");
            Console.Write("n! = ");
            bool isNInt = BigInteger.TryParse(Console.ReadLine(), out n);
            Console.Write("k! = ");
            bool isKInt = BigInteger.TryParse(Console.ReadLine(), out k);
            if(k > n) // Swap function 
            {
                BigInteger swap = n; n = k; k = swap;
            }
            if (isNInt && isKInt && 1 < k && k < n && n < 100)
            {
                // Main cicle
                for (int i = 1; i <= n; i++)
                {
                    facturialN *= i; // Facturial of n
                    if (i <= k)
                    {
                        facturialK *= i; // Facturial of k
                    }
                    if (i <= (n-k))
                    {
                        facturialNK *= i; // Facturial of n - k
                    }
                }

                //Calculating the formula n! / (k! * (n-k)!) and printing the result
                BigInteger result = facturialN / (facturialK * facturialNK);
                Console.WriteLine(result); 
            }
            else
            {
                Console.WriteLine("Bad input, try again!");
            }
            Main(); // Recursive function
            
        }
    }
}
