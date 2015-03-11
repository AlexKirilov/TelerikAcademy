using System;
using System.IO;
/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/

namespace _03.Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            try{
                //File 1 // Default file
                string pathF1 = @"C:\Users\Alex\Documents\Visual Studio 2013\Projects\TelerikAcademyP2HM8\03. Line Numbers\File1.txt";
                // This text is added only once to the file. 
                if (!File.Exists(pathF1))
                {
                    // Create a file to write to. 
                    using (StreamWriter test1 = File.CreateText(pathF1))
                    {
                        for (int i = 0; i < 10; i++)
                            test1.WriteLine("row {0}", i);

                    }
                }
                //File 2 // Default file
                string pathF2 = @"C:\Users\Alex\Documents\Visual Studio 2013\Projects\TelerikAcademyP2HM8\03. Line Numbers\FileOut2.txt";
                // This text is added only once to the file. 
                if (!File.Exists(pathF2))
                {
                    // Create a file to write to. 
                    using (StreamWriter test1 = File.CreateText(pathF2))
                    {
                        for (int i = 0; i < 10; i++)
                            test1.WriteLine("row {0}", i);

                    }
                }


                string[] file1 = File.ReadAllLines(pathF1);

                using (TextWriter textWriter = new StreamWriter(pathF2))
                    for (int i = 0; i < file1.Length; i++)
                            textWriter.WriteLine("Line {0} : \t{1}", i+1, file1[i]);
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
