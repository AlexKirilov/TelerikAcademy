using System;

//Problem 5. Formatting Numbers

    //Write a program that reads 3 numbers:
    //integer a (0 <= a <= 500)
    //floating-point b
    //floating-point c
    //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    //The number a should be printed in hexadecimal, left aligned
    //Then the number a should be printed in binary form, padded with zeroes
    //The number b should be printed with 2 digits after the decimal point, right aligned
    //The number c should be printed with 3 digits after the decimal point, left aligned.
namespace Formatting_Numbers
{
    class FormatingNum
    {
        static void Main()
        {
            int a;
            float b, c;
            Console.WriteLine("Please enter an integer value for a: ");
            Console.Write("a = ");
            bool isIntA = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please enter 2 floating values for b and c: ");
            Console.Write("b = ");
            bool isFloatB = float.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            bool isFloatC = float.TryParse(Console.ReadLine(), out c);

            bool values = isIntA && isFloatB && isFloatC && (a >= 0 && a <= 500);
            if(values) {
                Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
                Console.Write("|{0,10}|",
                Convert.ToString(a, 2).PadLeft(10, '0'));
                string str = b.ToString();
                int index = str.IndexOf(".");

                    Console.Write("{0,10:F2}|", b);

                str = c.ToString();

                    Console.Write("{0,-10:F3}|", c);

                Console.WriteLine();
            }
        }
    }
}
