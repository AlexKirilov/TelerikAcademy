using System;

/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:*/

namespace _01.FillTheMatrix
{
    class FillMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please enter the size of the matrix");
            Console.Write("n = ");
            int n;
            bool isNInt = int.TryParse(Console.ReadLine(), out n);
            if (isNInt)
            {
                //Fill matrix variant 'a'.
                int[,] matrix = new int[n, n];
                int row, col;
                int counter = 1; // for filling the matrix;

                for (col = 0; col < n; col++)
                {
                    for (row = 0; row < n; row++)
                    {
                        matrix[col, row] = col + 1 + row * n;
                        Console.Write("{0} ", matrix[col, row]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                //Variant b
                for (row = 0; row < n; row++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j % 2 != 0)
                        {
                            matrix[row, j] = -row + n + j * n;
                        }
                        else
                        {
                            matrix[row, j] = row + 1 + j * n;
                        }

                        Console.Write("{0} ", matrix[row, j]);
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();


                // Variant c
                int currentDigit = 1;

                for (row = 1; row < n + 1; row++)
                {
                    for (col = 0; col < row; col++)
                    {
                        matrix[n - row + col, col] = currentDigit;
                        currentDigit++;
                    }
                }

                for (row = n - 2; row >= 0; row--)
                {
                    for (col = row; col >= 0; col--)
                    {
                        matrix[row - col, n - col - 1] = currentDigit;
                        currentDigit++;
                    }
                }

                for (row = 0; row < n; row++)
                {
                    for (col = 0; col < n; col++)
                    {
                        Console.Write("{0,3}", matrix[row, col]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();

                ////Variand d - spiral
                //counter = 1;
                ////main loop
                //for (int i = 0; i <= n / 2; i++)
                //{
                //    if (counter == n * n) break;// cheking to break the loop if count is reach his max
                //    col = i; row = i;
                    
                //    //loop for -x and -y Coordinates
                //    for (int y = 0; y < ((2 * n) + (n - (2*i))); y++)
                //    {
                //        if (y < ((n / 2) - (2 * i)))//-x coord
                //        {
                //            counter++;
                //            matrix[row, col] = counter;
                //            row++;
                //        }
                //        else
                //        {
                //              // -y coord
                //            counter++;
                //            matrix[row, (n-i-1)] = counter;
                //            --row;
                //        }
                //    }
                //    //loop for x and y Coordinates
                //    for (int x = 0; x < ((2 * n) - (2 *(1+i))); x++)
                //    {
                //        if (x < (((2 * n) - (2 * (1 + i)))/2) ) // x coord
                //        {
                //            ++col;
                //            counter++;
                //            matrix[i, col] = counter;
                //        }
                //        else
                //        {
                //            --col; // y coord
                //            counter++;
                //            matrix[(n-i), col] = counter;
                //        }
                //    }
                //}
                ////printing on the console
                //for (int p = 0; p < n; p++)
                //{
                //    for (int a = 0; a < n; a++)
                //    {
                //        Console.Write(matrix[p, a] + "    ");
                //    }
                //    Console.WriteLine();
                //}
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bad Input, try again");
            }
        }
    }
}
