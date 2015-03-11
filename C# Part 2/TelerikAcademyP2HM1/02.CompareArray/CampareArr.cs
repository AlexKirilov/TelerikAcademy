using System;
/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.*/

namespace CompareArrays
{
    class CompareArr
    {
        static void Main()
        {

            int[] arrayOne = new int[5];
            int[] arrayTwo = new int[5];
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.WriteLine("arrayOne pos{0}", i);
                arrayOne[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("arrayTwo pos{0}", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            bool diverse = false;
            for (int i = 0; i < 5; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    diverse = true;
                }
            }

            if (diverse)
            {
                Console.WriteLine("The arrays are different");
            }
            else
            {
                Console.WriteLine("The arrays are equal");
            }
        }
    }
}
