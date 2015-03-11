using System;
/*Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/
namespace _02.Enter_Numbers
{
    class EnterNumbers
    {
        static int min = 0, max = 100, counter = 10;
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < counter; i++)
                {
                    min = ReadNumber();
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static int ReadNumber()
        {
            Console.Write("Enter number in range [{0}...{1}]: ", min + 1, max - 1);
            int number = int.Parse(Console.ReadLine());

            if (number <= min || number >= max)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
