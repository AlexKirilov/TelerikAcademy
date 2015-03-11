using System;
using System.IO;
/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.*/
namespace _02.Concatenate_text_files
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            try
            {
                //Creating filles

                //File 1
                string pathF1 = @"C:\test1.txt";
                // This text is added only once to the file. 
                if (!File.Exists(pathF1))
                {
                    // Create a file to write to. 
                    using (StreamWriter test1 = File.CreateText(pathF1))
                    {
                        for (int i = 0; i < 10; i++)
                            test1.WriteLine("file1 {0}", i);

                    }
                }

                //File 2
                string pathF2 = @"C:\test2.txt";
                // This text is added only once to the file. 
                if (!File.Exists(pathF2))
                {
                    // Create a file to write to. 
                    using (StreamWriter test1 = File.CreateText(pathF2))
                    {
                        for (int i = 0; i < 10; i++)
                            test1.WriteLine("file2 {0}", i);

                    }
                }

                //File 3 // Container File
                string pathF3 = @"C:\File3.txt";
                // This text is added only once to the file. 
                if (!File.Exists(pathF3))
                {
                    // Create a file to write to. 
                    using (StreamWriter test1 = File.CreateText(pathF3))
                    {
                        for (int i = 0; i < 10; i++)
                            test1.WriteLine("row {0}", i);

                    }
                }

                string[] file1 = File.ReadAllLines(pathF1);
                string[] file2 = File.ReadAllLines(pathF2);

                using (TextWriter textWriter = new StreamWriter(pathF3))
                    for (int i = 0; i < file2.Length; i++)
                       // for (int j = 0; j < file1.Length; j++)
                            textWriter.WriteLine("{0}\t{1}", file2[i], file1[i]);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Program is finnished the job");
            }
        }
    }
}
