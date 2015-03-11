using System;

//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter 
//and area formatted with 2 digits after the decimal point.
namespace CirclePerimeterArea
{
    class Program
    {
        static void Main()
        {
            double r;
            Console.Write("Enter the radius r:");
            bool isrInt = double.TryParse(Console.ReadLine(), out r);

            if (isrInt)
            {
                Console.WriteLine("Perimeter={0}", 2 * Math.PI * r);
                Console.WriteLine("Area={0}", Math.PI * r * r);
            }
            else
            {
                Console.WriteLine("Not a valid entry! r is not integer!");
            }
        }
    }
}
