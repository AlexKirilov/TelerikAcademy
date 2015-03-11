using System;
/*
 Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 */
namespace Problem8
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter the value");
            int val = int.Parse( Console.ReadLine());
            Boolean Prime = true;
            //Chekig if the number is smaller than 2 it`s false
            if (val < 2) { Prime = false; }
            for (int i = 2; i <= Math.Sqrt(val); i++)
            {
                if (val % i == 0) Prime = false;
            }
            Console.WriteLine("This number " + val + " is a Prime: " + Prime);
            Console.ReadLine();
        }
    }
}
