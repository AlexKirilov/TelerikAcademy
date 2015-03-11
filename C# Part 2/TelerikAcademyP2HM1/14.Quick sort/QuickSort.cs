using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_sort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Please enter the string of index {0} ", i);
                array[i] = Console.ReadLine();
            }

            string[] secondArray = new string[2 * n];
            bool[] sorted = new bool[n];
            int top = 0;
            int bottom = n - 1;
            bool result = false;

            while (true)
            {
                int counterBigger = 0;
                int counterSmaller = 0;
                secondArray[n] = array[top];
                for (int i = top + 1; i <= bottom; i++)
                {
                    if (secondArray[n].CompareTo(array[i]) < 0)
                    {
                        counterBigger = counterBigger + 1;
                        secondArray[n + counterBigger] = array[i];
                    }
                    else
                    {
                        counterSmaller = counterSmaller + 1;
                        secondArray[n - counterSmaller] = array[i];
                    }
                }

                for (int i = 0; i <= bottom - top; i++)
                {
                    array[top + i] = secondArray[n - counterSmaller + i];
                }
                sorted[top + counterSmaller] = true;

                bool start = false;
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (sorted[i])
                    {
                        counter++;
                        if (start)
                        {
                            bottom = i - 1;
                            break;

                        }
                    }
                    else if (!start)
                    {
                        top = i;
                        start = true;
                    }
                    else if (i == array.Length - 1)
                    {
                        bottom = array.Length - 1;
                    }
                    if (counter == array.Length)
                    {
                        result = true;
                    }
                }
                if (result)
                {
                    break;
                }
            }
            Console.WriteLine("The sorted array is ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
