using System;
/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.*/

namespace _03.EnglishDigit
{
    class ENDigit
    {
        static void IntInENWord(int n, string word)
        {
            n = n % 10;
            switch (n)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
            }
            Console.WriteLine(word);
        }

        static void Main()
        {
            Console.WriteLine("Enter an integer for ");
            Console.Write("Number = ");
            int Num;
            bool isNumInt = int.TryParse(Console.ReadLine(), out Num);
            if (isNumInt)
            {
                if (Num < 0) Num *= -1;
                IntInENWord(Num,"");
            }
        }
    }
}
