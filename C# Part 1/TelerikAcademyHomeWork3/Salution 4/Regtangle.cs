using System;

//Problem 4. Rectangles
//    Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace Salution_4
{
    class Regtangle
    {
        static void Main(string[] args)
        {
            //Read from the console values for regtangle;
            Console.WriteLine("Please anter values of the regtangle");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());

            //calculate perimeter and Araa
            float p = (2 * a) + (2 * b);
            float s = a * b;

            //Print the result on the console
            Console.WriteLine("\n" + " Perimeter p= " + p + "\n Area      S= " + s + "\n");
            Console.Read(); // For not closing the console
        }
    }
}
