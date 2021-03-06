﻿using System;
/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
 */

namespace _04.MaximalSequence
{
    class MaxSequence
    {
        static void Main()
        {
            int[] array = new int[10];
            int maxSequence = 0;
            int position = 0;
            int sequence = 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (array[i] == array[i + 1])
                    {
                        sequence += 1;

                    }
                    else
                    {
                        if (sequence > maxSequence)
                        {
                            maxSequence = sequence;
                            position = i;
                        }
                        sequence = 1;
                    }

                }
            }
            for (int j = position; j > position - maxSequence; j--)
            {
                //Console.WriteLine("position" + j);
                Console.Write("{0}", array[j]);
                if (j > position - maxSequence + 1)
                {
                    Console.Write(',');
                }
            }

        }
    }
}
