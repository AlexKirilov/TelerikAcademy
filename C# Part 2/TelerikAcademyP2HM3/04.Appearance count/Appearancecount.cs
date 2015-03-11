using System;
/*Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.*/

namespace _04.Appearance_count
{
    class Appearancecount
    {
        static int AppearanceCounter(double[] arr, int c, double n)
        {
            foreach (double val in arr)
            {
                if (val == n) c++; 
            }
            return c;
        }
        static void Main()
        {
            int size = 0;
            double number = 0;
            int counter = 0;
            Console.WriteLine("Enter the size of the array"); 
            Console.Write("Size = ");
            bool isSizeInt = int.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("Enter the looking number");
            Console.Write("number = ");
            bool isNumDouble = double.TryParse(Console.ReadLine(), out number);
            if (isSizeInt && size > 0 && isNumDouble);
            {
                double[] array = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Array[{0}] = ", i);
                    bool isDouble = double.TryParse(Console.ReadLine(), out array[i]);
                }
                int MethodCounter = AppearanceCounter(array, counter, number);
                //Console.WriteLine("\n The looking number is repeating {0} times", MethodCounter);

                //Program to testing the method
                foreach (double value in array)
                {
                    if (value == number) counter++;
                }
                bool equals = false;
                if (MethodCounter == counter) equals = true;
                Console.WriteLine("\nTesting the method counter(method) = {0} times and test counter = {1} times",MethodCounter, counter);
                Console.WriteLine("\nThe method is equals to test program it`s  = {0}", equals);
            }

            

        }
    }
}
