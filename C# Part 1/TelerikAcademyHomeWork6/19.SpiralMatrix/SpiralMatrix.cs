using System;

//Problem 19.** Spiral Matrix

//  Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and
//  prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of matrix:  "); Console.Write("n = ");
            int n = 0, count = 0;
            int row, col;
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            if (isNInt)
            {
                int[,] matrix = new int[n, n];
                //main loop
                for (int i = 0; i <= n / 2; i++)
                {
                    if (count == n * n) break;// cheking to break the loop if count is reach his max
                    row = i; col = i - 1;
                    //loop for x and y Coordinates
                    for (int x = 0; x < ((2 * n) + (i * (-4) - 1)); x++)
                    {
                        if (count == n * n) break; // cheking to break the loop if count is reach his max
                        if (x < (((2 * n) + (i * (-4) - 1)) / 2) + 1) // x coord
                        {
                            ++col;
                            matrix[row, col] = ++count;
                        } else {
                            ++row; // y coord
                            matrix[row, col] = ++count;
                        }
                    }
                    //loop for -x and -y Coordinates
                    for (int y = 0; y < ((2 * n) + (i * (-4) - 3)); y++)
                    {
                        if (count == n * n) break; // cheking to break the loop if count is reach his max
                        if (y < (((2 * n) + (i * (-4) - 3)) / 2) + 1)//-x coord
                        {
                            --col;
                            matrix[row, col] = ++count;
                        }  else  {
                            --row;  // -y coord
                            matrix[row, col] = ++count;
                        }
                    }
                }
                //printing on the console
                for (int p = 0; p < n; p++) {
                    for (int a = 0; a < n; a++)
                    {
                        Console.Write(matrix[p, a] + "    ");
                    }
                    Console.WriteLine();
                }
            } else {
                Console.WriteLine("Bad input,try again");
            }
        }
    }
}
