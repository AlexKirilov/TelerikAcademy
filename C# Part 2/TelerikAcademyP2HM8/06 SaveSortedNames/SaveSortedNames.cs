using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan 
Peter 
Maria 
George	George 
Ivan 
Maria 
Peter*/
namespace _06_SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            //file is in 'bin/Debug' directory of the project
            using (StreamReader unsorted = new StreamReader("unsorted.txt"))
            {
                List<string> names = new List<string>();
                for (string currName = unsorted.ReadLine(); currName != null; currName = unsorted.ReadLine())
                {
                    names.Add(currName);
                }
                names.Sort();
                using (StreamWriter sorted = new StreamWriter("sorted.txt"))
                {
                    foreach (string name in names)
                    {
                        sorted.WriteLine(name);
                    }
                }
            }
            Console.WriteLine("Names are sorted!");
        }
    }
}
