using System;
/*Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K.*/

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            string intArray;
            Console.WriteLine("Enter the array of int in one row with white space between the integers");
            Console.Write("n = ");
            intArray = Console.ReadLine();
            int k;
            Console.WriteLine("Enter the integer");
            Console.Write("k = ");
            bool isKInt = int.TryParse(Console.ReadLine(), out k);

            if (isKInt && intArray.Length > 3)
            {
                int maxValue = 0;
                string[] tokens = intArray.Split(' ');

                int[] arr = Array.ConvertAll<string, int>(tokens, int.Parse);


                ////Bubble sort if arr[n] n < 15
                //if (arr.Length < 15)
                //{
                //    for (int i = 0; i < arr.Length - 1; i++)
                //    {
                //        for (int j = 0; j < arr.Length - 1; j++)
                //        {
                //            if (arr[j] > arr[j + 1]) // swap the elements
                //            {
                //                int tmp = arr[j];
                //                arr[j] = arr[j + 1];
                //                arr[j + 1] = tmp;
                //            }
                //        }
                //    }
                //}
                //else
                //{
                    // Sort the array
                    Array.Sort(arr);
                    //Quicksort(tokens, 0, tokens.Length - 1);
                //}


                
                for (int i = 0; i < arr.Length; i++)
                {

                    if (arr[i] < k)
                    {
                        maxValue = arr[i];
                    }
                }
                Array.BinarySearch(arr, maxValue);
                if (arr[0] > k)
                {
                    Console.WriteLine("No number is lesser than the given max value.");
                }
                else
                {
                    Console.WriteLine("Max number lesser than the given max value is: {0}", maxValue);
                }


            }
            else
            {
                Console.WriteLine("Bad Input, try again");
            }


        }

        ////QuickSort 
        //public static void Quicksort(IComparable[] elements, int left, int right)
        //{
        //    int i = left, j = right;
        //    IComparable pivot = elements[(left + right) / 2];

        //    while (i <= j)
        //    {
        //        while (elements[i].CompareTo(pivot) < 0)
        //        {
        //            i++;
        //        }

        //        while (elements[j].CompareTo(pivot) > 0)
        //        {
        //            j--;
        //        }

        //        if (i <= j)
        //        {
        //            // Swap
        //            IComparable tmp = elements[i];
        //            elements[i] = elements[j];
        //            elements[j] = tmp;

        //            i++;
        //            j--;
        //        }
        //    }

        //    // Recursive calls
        //    if (left < j)
        //    {
        //        Quicksort(elements, left, j);
        //    }

        //    if (i < right)
        //    {
        //        Quicksort(elements, i, right);
        //    }
        //}
    }
}
