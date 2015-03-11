using System;
/*Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.*/

namespace _06.FirstLargerthanNeighbours
{
    class FLNeighbours
    {
        private static int IsBiggerThanNeighbours(int[] numbers, int index)
        {
            foreach (int val in numbers)
            {
                if (numbers[val - 1] < numbers[val] && numbers[val] > numbers[val + 1])
                {
                    return val;
                }
            }
            return index = -1;
  
        }
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the elements of the array");
            int[] numbers = new int[length];
            int index = 1;
            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            index = IsBiggerThanNeighbours(numbers, index);
            Console.WriteLine("\nThe position of the biggest numbers of the neibours is {0} from 0 to {1}", index, length-1);
            Console.WriteLine("The biggest number is {0}", numbers[index]); // Bonus :D

        }
    }
}
