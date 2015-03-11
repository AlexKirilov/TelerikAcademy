using System;

/*
Problem 9. Sorting array

    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
*/
//??????????? Sortirane na celiqt masiv ili ot nachalniq index
//??????????? Da se sortira predi turseneto na maximalniqt element ili sled tova
namespace _09.Sorting_array
{
    class Sort
    {
        private static int MaxElementInArray(int[] arr, int MAX, int pos)
        {
            int size = arr.Length - 1;
            for (int i = pos; i <= size; i++)
            {
                MAX = Math.Max(MAX, arr[i]);
            }
            return MAX;
        }

        private static int[] SortArray( int[] arr )
        {
            Console.WriteLine("Please choose how to sort the array: ");
            Console.WriteLine("1: Ascending");
            Console.WriteLine("2: Descending");
            int diraction = int.Parse(Console.ReadLine());
            switch (diraction)
            {
                case 1: Array.Sort<int>(arr); break;
                case 2: Array.Sort<int>(arr); Array.Reverse(arr); break;
            }
            return arr;
        }
        static void Main()
        {
            Console.Write("Enter the lengt of the array ");
            int arrLenght;
            bool isArrInt = int.TryParse(Console.ReadLine(), out arrLenght);
            if (arrLenght < 0) arrLenght *= -1;
            int[] array = new int[arrLenght];

            //Filling the array
            for (int i = 0; i < arrLenght; i++)
            {
                Console.Write("Array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the start position of searching for Max element");
            Console.Write("position = ");
            int pos = int.Parse(Console.ReadLine());
            int max;
            if (pos > arrLenght) { Console.WriteLine("Bad input, position is out of range");  }
            else
            {
                max = array[pos];
                max = MaxElementInArray(array, max, pos);
                Console.WriteLine("MAX = {0}", max);
                array = SortArray(array);
                Console.WriteLine("Array is Sorted :\n");
                foreach (int val in array) Console.Write(" {0}", val);
                Console.ReadLine(); // To not close the Console
            }
        }
    }
}
