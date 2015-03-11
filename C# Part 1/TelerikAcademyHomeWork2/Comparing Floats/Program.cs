using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Problem 13.* Comparing Floats

    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/
namespace Comparing_Floats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = a - b;
            c = Math.Abs(c);
            double eps = 0.000001;
            string explanation;
            Boolean buu;

            if (c < eps)
            {
                buu = true;
                explanation = "The difference " + c + " < eps";
            }
            else
            {
                buu = false;
                explanation = "Border case. The difference" + eps + " == eps. We consider the numbers are different.";
            }
            
            if (c > 0.01) explanation = "The difference of" + c + " is too big (> eps)";


            Console.WriteLine("\n\n" + a + "  " + b + "  " + buu + "  " + explanation + "\n");
        }
    }
}
