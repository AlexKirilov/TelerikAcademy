using System;
using System.Numerics;
/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.*/

namespace _08.NumberAsArray
{
    class NumAsArray
    {
        private static string PositiveArraySwapFunc(BigInteger number, string strNum)
        {
            int size = number.ToString().Length; // size of the number
            BigInteger[] arrNum = new BigInteger[size];

            for(int i = size; i > 0; i--){
                
                //Put the last digit at first place
                if (i == size) arrNum[0] = number % 10;
                else
                {
                    arrNum[i+1] = number % 10;
                    number /= 10;
                }
            }
            strNum = arrNum.ToString();

            return strNum;
        }
        static void Main()
        {
            string printNum = "";
            Console.WriteLine("Please enter first number between 0 and 10 000 digits");
            BigInteger number1;
            bool isNum1Int = BigInteger.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Please enter first number between 0 and 10 000 digits");
            BigInteger number2;
            bool isNum2Int = BigInteger.TryParse(Console.ReadLine(), out number2);

            if (isNum1Int && isNum2Int)
            {
                //First number
                if (number1 < 0) number1 *= -1;
                printNum = PositiveArraySwapFunc(number1, printNum).ToString();
                Console.WriteLine("\n" + printNum);
                
                //Second number
                if (number2 < 0) number2 *= -1;
                printNum = PositiveArraySwapFunc(number2, printNum).ToString();
                Console.WriteLine("\n" + printNum);
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
        }
    }
}
