using System;

//Problem 6. Quadratic Equation

//  Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
namespace QuadraticEquation
{
    class Equation
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("Please enter values for a, b, c");
            Console.Write("a= ");
            bool isAdouble = double.TryParse(Console.ReadLine(), out a);
            Console.Write("\nb= ");
            bool isBdouble = double.TryParse(Console.ReadLine(), out b);
            Console.Write("\nc= ");
            bool isCdouble = double.TryParse(Console.ReadLine(), out c);
            double x1, x2;

            if (isAdouble && isBdouble && isCdouble) {
                double des = (b * b) - (4 * a * c);
                if (des > 0)
                {
                    x1 = (-b + Math.Sqrt(des)) / (2 * a);
                    x2 = (-b - Math.Sqrt(des)) / (2 * a);
                    Console.WriteLine("\nX1 = {0} \nX2 = {1} ", x1, x2);
                }else if (des == 0) {
                    x1 = x2 = -b / 2 * a;
                    Console.WriteLine("x1={0}", x1);
                    Console.WriteLine("x2={0}", x2);
                } else {
                    Console.WriteLine("There are no real roots!");
                }
            } else {
                Console.WriteLine("Bad Input");
            }
            Main();//Recursive function
        }
    }
}
