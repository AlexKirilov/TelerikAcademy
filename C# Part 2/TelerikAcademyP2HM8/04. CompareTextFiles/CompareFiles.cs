using System;
using System.IO;
/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.*/
namespace _04.CompareTextFiles
{
    class CompareFiles
    {
        static void Main()
        {
            int countEQ = 0;
            int countNotEQ = 0;
            try
            { 
                Console.WriteLine("Enter the full path of the file 1");
                string path1 = Console.ReadLine();
                Console.WriteLine("Enter the full path of the file 2");
                string path2 = Console.ReadLine();

                //Default Values
                //Start
                if (path1.Length < 4) 
                {
                    path1 = @"C:\Users\Alex\Documents\Visual Studio 2013\Projects\TelerikAcademyP2HM8\04. CompareTextFiles\File1.txt";
                    // This text is added only once to the file. 
                    if (!File.Exists(path1))
                    {   using (StreamWriter test1 = File.CreateText(path1))
                        {
                            test1.WriteLine("row 0");
                            test1.WriteLine("row 1");
                            test1.WriteLine("qwerty");
                            test1.WriteLine("1 wor");
                            test1.WriteLine("2 row");
                        }
                    }
                }

                if (path2.Length < 4)
                {
                    path2 = @"C:\Users\Alex\Documents\Visual Studio 2013\Projects\TelerikAcademyP2HM8\04. CompareTextFiles\File2.txt";
                    // This text is added only once to the file. 
                    if (!File.Exists(path2))
                    {
                        using (StreamWriter test2 = File.CreateText(path2))
                        {
                            test2.WriteLine("row 0");
                            test2.WriteLine("row 1");
                            test2.WriteLine("pasti");
                            test2.WriteLine("1 wor");
                            test2.WriteLine("sladoled");
                        }
                    }
                }
                //End Default values

                string[] file1 = File.ReadAllLines(path1);
                string[] file2 = File.ReadAllLines(path2);

                        for (int i = 0; i < file1.Length; i++)
                        {
                            if (file1[i].Equals(file2[i])) countEQ++;
                            else countNotEQ++;
                        }
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
                Console.WriteLine("The numbers of row that are Equal are:    {0}", countEQ);
                Console.WriteLine("The numbers of row that are NotEqual are: {0}", countNotEQ);
            }

        }
    }
}
