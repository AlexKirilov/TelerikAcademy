using System;

//Problem 8. Digit as Word

//  Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//  Print “not a digit” in case of invalid input.
//  Use a switch statement.

namespace Digit_as_Word
{
    class DigitWord
    {
        static void Main()
        {
            int x;
            Console.WriteLine("\nEnter digit beetween 1 to 9: ");
            bool isXInt = int.TryParse(Console.ReadLine(), out x);
            if (isXInt && x <= 9 && x >= 0)
            {
                switch (x+1)
                {
                    case 1: Console.WriteLine("Zero");  break;
                    case 2: Console.WriteLine("one"); break;
                    case 3: Console.WriteLine("two"); break;
                    case 4: Console.WriteLine("three"); break;
                    case 5: Console.WriteLine("four"); break;
                    case 6: Console.WriteLine("five"); break;
                    case 7: Console.WriteLine("six"); break;
                    case 8: Console.WriteLine("seven"); break;
                    case 9: Console.WriteLine("eight"); break;
                    case 10: Console.WriteLine("nine"); break;
                }

            }
            else { Console.WriteLine("\nnot a digit");  }
            Main();// Recursive function

        }
    }
}
