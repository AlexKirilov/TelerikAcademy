using System;

namespace Salution_5
{
    class thirdDigit
    {
        static void Main(string[] args)
        {
            //Read from the console
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            //third Digit
            int restNumber = number / 100;
            int thirdDigit = restNumber % 10;
            //Cheking is it 7 or  not
            bool isSeven = thirdDigit == 7;
            //Print on the console
            Console.WriteLine("Third digit of this number is 7 = " + isSeven);
            Console.Read(); // For not closing the console
        }
    }
}
