using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            
            double a, b, h;
            //Cheking for valid entry
            Console.Write("Enter the first side of the trapezoid: \n");
            bool isValid_a = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nEnter the second side of the trapezoid: \n");
            bool isValid_b = double.TryParse(Console.ReadLine(), out b);
            Console.Write("\nEnter the height of the trapezoid: \n");
            bool isValid_h = double.TryParse(Console.ReadLine(), out h);

            //if all parameter are valid can contion
            if (isValid_a && isValid_b && isValid_h)
            {
                double area = (a + b) * 0.5 * h;
                Console.WriteLine("\nThe area is:  {0}\n", area);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }

        }
    }
}
