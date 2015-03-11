using System;

//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

namespace Play_with_Int__Double_and_String
{
    class PlayWith
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 -- > Int");
            Console.WriteLine("2 -- > Double");
            Console.WriteLine("3 -- > String");
            int a;
            bool isAInt = int.TryParse(Console.ReadLine(), out a);
            if (isAInt && a < 4 && a > 0)
            {
                switch (a)
                {
                    case 1: // if a is int
                        Console.WriteLine("Please enter a int");
                        int x;
                        bool isXInt = int.TryParse(Console.ReadLine(), out x);
                        if (isXInt) { Console.WriteLine(++x); }
                        else {
                            Console.WriteLine("Bad input. The symbol is not int, try again");
                            Main(); // Recursive function
                        }
                    break;

                    case 2:// if a is double
                        Console.WriteLine("Please enter a double:");
                        double y;
                        bool isYInt = double.TryParse(Console.ReadLine(), out y);
                        if (isYInt) { Console.WriteLine(++y); }
                        else {
                            Console.WriteLine("Bad input. The symbol is not double, try again");
                            Main(); // Recursive function
                        }
                    break;

                    case 3: // if a is a string
                        Console.WriteLine("Please enter a String");
                        string str = Console.ReadLine();      
                        Console.WriteLine(str + "*");
                    break;
                }

            }
            else { Console.WriteLine("Bad input, try again"); Main(); }// Recursive function
            
        }
    }
}
