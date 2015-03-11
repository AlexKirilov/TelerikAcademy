using System;
using System.IO;
/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.*/

namespace _01.OddLines
{
    class ReadOddLines
    {
        static void Main()
        {
            int counter = 0;
            string line;

            ////To crate file with 20 rows
            //string path = @"c:\test.txt";
            //    // This text is added only once to the file. 
            //    if (!File.Exists(path))
            //    {
            //        // Create a file to write to. 
            //        using (StreamWriter sw = File.CreateText(path))
            //        {
            //            for (int i = 0; i < 20; i++ )
            //                sw.WriteLine("row {0}",i);
                        
            //        }
            //    }
            try
            {
                // Read the file and display it line by line.
                StreamReader file =
                    new StreamReader(@"c:\test.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if(counter %2 == 0) System.Console.WriteLine(line);
                    counter++;
                }
                file.Close();
            }
            catch (UnauthorizedAccessException UAEx)
            {
                Console.WriteLine(UAEx.Message);
            }
            catch (PathTooLongException PathEx)
            {
                Console.WriteLine(PathEx.Message);
            }
            finally
            {
                System.Console.WriteLine("\nThere were {0} rows.\n", counter);
                // Suspend the screen.
                Console.WriteLine("Good bay\n");
            }
        }
    }
}
