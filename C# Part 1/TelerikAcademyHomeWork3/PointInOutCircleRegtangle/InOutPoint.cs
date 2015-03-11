using System;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2)
namespace PointInOutCircleRegtangle
{
    class InOutPoint
    {
        static void Main()
        {
            bool check = false;
            double X, Y;
            Console.Write("Enter X and Y coordinates: \n");
            if ( (double.TryParse(Console.ReadLine(), out X)) && (double.TryParse(Console.ReadLine(), out Y)) )
            {
                if ((X >= -1 && Y >= -1) && (X <= 6 && Y <= 1))
                {
                 //Do nothing   
                }
                else
                {
                    double dX = X - 1;
                    double dY = Y - 1;
                    if ((dX * dX + dY * dY) <= 9)
                    {
                        check = true;
                    }
                }
                Console.WriteLine("\nPoints :  ({0} , {1}) \nwith in the circle and out of the rectangle?: {2}", X, Y, check);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
            Main();//Recursive function
        }
    }
}
