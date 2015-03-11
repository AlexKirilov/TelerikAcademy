using System;
//Problem 3. Divide by 7 and 5

    //Write a Boolean expression that checks for given integer if it can be divided (without remainder)
    //by 7 and 5 at the same time.
namespace Salution_3
{
    class Divide
    {
        static void Main(string[] args)
        {
            bool exp;
            //Read from the console and parse to int
            int val = int.Parse(Console.ReadLine());

            //Cheks if is % 5 or 7
            if ((val % 5 == 0) && (val % 7 == 0)) exp = true;
            else exp = false;

            Console.WriteLine("The value: " + val + "Can diveded by 5 and 7 " + exp);
            Console.Read(); // For not closing the console
        }
    }
}
