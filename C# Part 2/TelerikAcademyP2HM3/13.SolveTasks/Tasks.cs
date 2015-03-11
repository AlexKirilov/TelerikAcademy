using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
/*Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/

namespace _13.SolveTasks
{
    class Tasks
    {
        static void Main()
        {
            Console.WriteLine("Please choose from the menu Menu:");
            Console.WriteLine("****************************************************");
            Console.WriteLine();
            Console.WriteLine("1: Reversing digits of a number");
            Console.WriteLine("2: Calculating the average of a sequence.");
            Console.WriteLine("3: Solves a linear equation  like \"a * x + b = 0\"");
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.Write("Your choice is: ");
            int choice;
            bool isChoice = int.TryParse(Console.ReadLine(), out choice);
            if (isChoice && choice >= 1 && choice <= 3)
            {
                switch (choice)
                {
                    case 1: choice1(); break;
                    case 2: choice2(); break;
                    case 3: choice3(); break;
                }
            }
            else
            {
                Console.WriteLine("Bad input, try again");
            }
        }
        private static  void choice1(){
            Console.Write("Enter number to reverse: ");
            string numberInput = Console.ReadLine();
            BigInteger numberToReverse = 0;

                numberToReverse = BigInteger.Parse(numberInput);
                Console.WriteLine("Reversed number");
                Console.WriteLine(ReverseDigits(numberToReverse));
        }

        private static string ReverseDigits(BigInteger num)
        {
            string result = String.Empty;
            string number = num.ToString();
            StringBuilder sb = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            result = sb.ToString();
            return result;
        }
        private static void choice2()
        {
            List<int> list = new List<int>();
            Console.Write("Enter sequence length: ");
            string seq = Console.ReadLine();
            int length = 0;
            length = int.Parse(seq);
            for (int i = 0; i < length; i++)
            {
                Console.Write("Sequence[{0}] = ", i);
                string integerStr = Console.ReadLine();
                list.Add(int.Parse(integerStr));
            }
            int average = CalculateAvg(list.ToArray());
            Console.WriteLine("Average = {0}", average);
        }

        private static int CalculateAvg(int[] sequance)
        {
            if (sequance.Length == 0)
            {
                throw new ArgumentException("The sequence should not be empty");
            }
            int sum = 0;
            for (int i = 0; i < sequance.Length; i++)
            {
                sum += sequance[i];
            }
            int result = sum / (sequance.Length - 1);
            return result;
        }

        private static void choice3()
        {
            LinearEquation();
        }


        private static void LinearEquation()
        {

            Console.Write("Enter value for 'a = ' ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for 'b = ' ");
            double b = double.Parse(Console.ReadLine());
            if (a != 0)
            {
                double x = -b / a;
                Console.WriteLine("X= {0}", x);
            }
            else
            {
                Console.WriteLine("Enter value different from 0");
                LinearEquation();
            }
        }
    }
}
