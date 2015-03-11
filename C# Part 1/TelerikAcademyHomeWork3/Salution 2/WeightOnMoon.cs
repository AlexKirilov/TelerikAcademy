using System;

//Problem 2. Gravitation on the Moon

    //The gravitational field of the Moon is approximately 17% of that on the Earth.
    //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

namespace Salution_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! \n Please enter your weight. \n ");
            //Read from the console - "Weight";
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight it will be approximately " + (weight * 0.17) );
            Console.Read(); // For not closing the console
        }
    }
}
