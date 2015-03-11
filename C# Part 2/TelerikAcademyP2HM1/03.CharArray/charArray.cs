using System;
/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/

namespace _03.CharArray
{
    class charArray
    {
        static void Main()
        {
            char[] firstArray = new char[4];
            char[] secondArray = new char[4];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("firstArray position {0}", i);
                firstArray[i] = char.Parse(Console.ReadLine());
                Console.WriteLine("secondArray position {0}", i);
                secondArray[i] = char.Parse(Console.ReadLine());
            }
            bool different = true;
            bool isFirst = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    different = false;
                    if (firstArray[i] > secondArray[i])
                    {
                        isFirst = false;
                    }
                }
            }
            if (different)
            {
                Console.WriteLine("The arrays are equal");
            }
            else
            {
                // Console.WriteLine("The arrays are not equal");
                if (isFirst)
                {
                    Console.WriteLine("The firstArray is lexicographically first");
                }
                else
                {
                    Console.WriteLine("The secondArray is lexicographically first");
                }
            }
        }
    }
}
