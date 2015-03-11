using System;
using System.IO;
/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).*/
namespace _07.ReplaceSub_string
{
    class ReplaceSub
    {
        static void Main()
        {
            //file is in 'bin/Debug' directory of the project
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter output = new StreamWriter("result.txt"))
                {
                    for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                    {
                        string newLine = line.Replace("start", "finish");
                        output.WriteLine(newLine);
                    }
                }
            }
            Console.WriteLine("Replacing done!");
        }
    }
}
