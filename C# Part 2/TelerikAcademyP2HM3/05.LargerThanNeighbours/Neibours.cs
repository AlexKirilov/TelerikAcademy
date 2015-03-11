using System;
/*Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).*/

namespace _05.LargerThanNeighbours
{
    class Neibours
    {
        private static bool IsBiggerThanNeighbours(int[] numbers, int index)
        {
            bool isBigger = false;
            if (numbers[index - 1] < numbers[index] && numbers[index] > numbers[index + 1])
            {
                isBigger = true;
            }

            return isBigger;
        }

        static void Main()
        {
            Console.WriteLine("Please enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the elements of the array");
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the position of the element to check for");
            int index = int.Parse(Console.ReadLine());

            if (index == 0 || index == length - 1)
            {
                Console.WriteLine("Some of the neighbours does not exist");
            }
            else if (0 < index && index < length - 1)
            {
                bool isBigger = IsBiggerThanNeighbours(numbers, index);
                Console.WriteLine("The element at position" + index + "is bigger than its two neighbours: " + isBigger);
            }
            else
            {
                throw new IndexOutOfRangeException("The index is not in the range");
            }
        }
    }
}
