using System;

//Problem 11.* Number as Words

//Write a program that converts a number in
//the range [0…999] to words, corresponding to the English pronunciation.

namespace _11.NumbersAsWords
{
    class NumbersAsWords
    {
        static void Main()
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                int spec = 0;
                if (((input / 100) % 10 >= 1) && ((input / 100) % 10 <= 9))
                {
                    int firstDigit = (input / 100) % 10;
                    switch (firstDigit)
                    {
                        case 1:
                            Console.Write("one hundred ");
                            break;
                        case 2:
                            Console.Write("two hundred ");
                            break;
                        case 3:
                            Console.Write("three hundred ");
                            break;
                        case 4:
                            Console.Write("four hundred ");
                            break;
                        case 5:
                            Console.Write("fife hundred ");
                            break;
                        case 6:
                            Console.Write("six hundred ");
                            break;
                        case 7:
                            Console.Write("seven hundred ");
                            break;
                        case 8:
                            Console.Write("eight hundred ");
                            break;
                        case 9:
                            Console.Write("nine hundred ");
                            break;
                    }
                    if ((input % 10 != 0) || ((input % 100) <= 90) && (input % 100) >= 10)
                    {
                        int and = 1;
                        switch (and)
                        {
                            case 1:
                                Console.Write("and ");
                                break;
                        }
                    }
                }
                if (((input / 10) % 10 >= 0) && ((input / 10) % 10 <= 9))
                {
                    if ((input % 10 == 0) && (input != 0))
                    {
                        spec++;
                    }
                    int secondDigit = (input / 10) % 10;
                    switch (secondDigit)
                    {
                        case 1:
                            int special = input % 100;
                            spec++;
                            switch (special)
                            {
                                case 10:
                                    Console.WriteLine("ten");
                                    break;
                                case 11:
                                    Console.WriteLine("eleven");
                                    break;
                                case 12:
                                    Console.WriteLine("twelve");
                                    break;
                                case 13:
                                    Console.WriteLine("thirteen");
                                    break;
                                case 14:
                                    Console.WriteLine("fourteen");
                                    break;
                                case 15:
                                    Console.WriteLine("fiveteen");
                                    break;
                                case 16:
                                    Console.WriteLine("sixteen");
                                    break;
                                case 17:
                                    Console.WriteLine("seventeen");
                                    break;
                                case 18:
                                    Console.WriteLine("eighteen");
                                    break;
                                case 19:
                                    Console.WriteLine("nineteen");
                                    break;
                            }
                            break;
                        case 2:
                            Console.Write("twenty ");
                            break;
                        case 3:
                            Console.Write("thirty ");
                            break;
                        case 4:
                            Console.Write("forty ");
                            break;
                        case 5:
                            Console.Write("fifty ");
                            break;
                        case 6:
                            Console.Write("sixty ");
                            break;
                        case 7:
                            Console.Write("seventy ");
                            break;
                        case 8:
                            Console.Write("eighty ");
                            break;
                        case 9:
                            Console.Write("ninety ");
                            break;
                    }
                }
                if ((input % 10 >= 0) && (input % 10 <= 9) && (spec == 0))
                {
                    int inputLastDigit = input % 10;
                    switch (inputLastDigit)
                    {
                        case 0:
                            Console.Write("zero");
                            break;
                        case 1:
                            Console.Write("one");
                            break;
                        case 2:
                            Console.Write("two");
                            break;
                        case 3:
                            Console.Write("three");
                            break;
                        case 4:
                            Console.Write("four");
                            break;
                        case 5:
                            Console.Write("fife");
                            break;
                        case 6:
                            Console.Write("six");
                            break;
                        case 7:
                            Console.Write("seven");
                            break;
                        case 8:
                            Console.Write("eight");
                            break;
                        case 9:
                            Console.Write("nine");
                            break;
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
