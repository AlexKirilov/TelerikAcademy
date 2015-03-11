using System;


namespace _03.SequenceNMatrix
{
    class Sequence
    {
        static void Main()
        {
            Console.WriteLine("enter numbers of rows for array ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter numbers of coloms for array");
            int m = int.Parse(Console.ReadLine());

            string[,] array = new string[n, m];
            // Read data from console
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Array[{0},{1}] = ", i, j);
                    array[i, j] = Console.ReadLine();
                }
            }

            int MElement = 0, CurElemenr = 0;
            string maxStr = "";

            // Find sequence
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Horizontal
                    CurElemenr = 0;
                    for (int k = i; k < n - 1; k++)
                    {
                        if (array[j, k + 1] == array[j, k])
                        {
                            CurElemenr++;
                        }

                        if (CurElemenr > MElement)
                        {
                            MElement = CurElemenr;
                            maxStr = array[j, k];
                        }
                    }

                    // Vertical
                    CurElemenr = 0;
                    for (int k = j; k < m - 1; k++)
                    {
                        if (array[k, i] == array[k + 1, i])
                        {
                            CurElemenr++;
                        }

                        if (CurElemenr > MElement)
                        {
                            MElement = CurElemenr;
                            maxStr = array[k, i];
                        }
                    }

                    // Diagonals
                    CurElemenr = 0;
                    for (int k = i, l = j; (k < n - 1) && (l < m - 1); k++, l++)
                    {
                        if (array[l, k] == array[l + 1, k + 1])
                        {
                            CurElemenr++;
                        }

                        if (CurElemenr > MElement)
                        {
                            MElement = CurElemenr;
                            maxStr = array[l, k];
                        }
                    }
                }
            }

            for (int i = 0; i < MElement + 1; i++) Console.Write(maxStr + ", ");
        }
    }
}
