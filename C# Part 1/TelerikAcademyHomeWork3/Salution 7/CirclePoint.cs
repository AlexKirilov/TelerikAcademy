using System;
/*
 Problem 7. Point in a Circle

        Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */

namespace Salution_7
{
    class CirclePoint
    {
        static void Main(string[] args)
        {
            //Read from console
            Console.WriteLine("Please enter coordinates \n");
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            int r = 2; // Radius
            //Cheking is it the coordinates in a Circle or not
            bool isInside = Math.Pow(x,2) + Math.Pow(y,2) <= Math.Pow(r,2);
            //Print the result
            Console.WriteLine("\nThese coordinates are inside the circle = " + isInside);
            Console.Read(); // For not closing the console
        }
    }
}
