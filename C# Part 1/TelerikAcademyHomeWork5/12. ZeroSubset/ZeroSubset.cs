using System;

//Problem 12.* Zero Subset

//  We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//  Assume that repeating the same subset several times is not a problem.

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splited = input.Split(' ');
            int[] numbers = new int[splited.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(splited[i]);
            }
            if (numbers[0] + numbers[1] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[1]);
            }
            if (numbers[0] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[2]);
            }
            if (numbers[0] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[3]);
            }
            if (numbers[0] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[4]);
            }
            if (numbers[0] + numbers[1] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[2]);
            }
            if (numbers[0] + numbers[1] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[3]);
            }
            if (numbers[0] + numbers[1] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[4]);
            }
            if (numbers[0] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[2], numbers[3]);
            }
            if (numbers[0] + numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[2], numbers[4]);
            }
            if (numbers[0] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[3], numbers[4]);
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[2], numbers[3]);
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[2], numbers[4]);
            }
            if (numbers[0] + numbers[1] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[0], numbers[1], numbers[3], numbers[4]);
            }
            if (numbers[0] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[0], numbers[2], numbers[3], numbers[4]);
            }
            if (numbers[0] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[0], numbers[2], numbers[3], numbers[4]);
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            }
            if (numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[1], numbers[2], numbers[3], numbers[4]);
            }
            if (numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[2], numbers[3]);
            }
            if (numbers[1] + numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[2], numbers[4]);
            }
            if (numbers[1] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[3], numbers[4]);
            }
            if (numbers[1] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[2]);
            }
            if (numbers[1] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[3]);
            }
            if (numbers[1] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[4]);
            }
            if (numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[2], numbers[3], numbers[4]);
            }
            if (numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[3]);
            }
            if (numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[4]);
            }
            if (numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[3], numbers[4]);
            }
            else
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
