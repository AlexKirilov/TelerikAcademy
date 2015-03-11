using System;

/*
Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©

*/

namespace IsoscelesTriangle
{
    class Triengle
    {
        static void Main()
        {
            String x = "©";
            //Version 1

            Console.WriteLine(    "   " + x + "   ");
            Console.WriteLine( "  " + x +" " + x + "  ");
            Console.WriteLine(" " + x + "   " + x + " ");
            Console.WriteLine( x + " " + x +" " + x +" "+ x);

            Console.WriteLine(" ");
            //Version 2
            
            //Loop for height
            for (int i = 1; i < 5; i++)
            {
                
                //Loop for deep
                for (int j = 0; j < 4 ; j++)
                {
                    int blank = 5 - i;
                    if (blank == j)
                    {
                        Console.Write(x + " ");
                    }
                    else if (i == 4 && blank == j - 1) Console.Write(x);
                    else Console.Write(" ");
                    blank--;
                   
                }
                for (int y = 4; y > 0; y--)
                {
                    int blank = 5 - i;
                    if (i == 4 && blank == y-2) Console.Write(x);
                    if (blank == y)
                    {
                        Console.Write(x + " ");
                    }
                    else Console.Write(" ");
                    blank++;

                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
