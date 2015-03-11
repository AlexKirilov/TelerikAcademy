using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
 and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/
namespace _05.Parse_tags
{
    class ParseToUpperCase
    {
        static void Main()
        {
            Console.WriteLine("Enter some string");
            string str = Console.ReadLine();
            //Default value;
            if(str.Length < 10) str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            
            string[] words = str.Split('<','>');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "upcase") { words[i] = ""; words[i + 1] = words[i + 1].ToUpper(); }
                if (words[i] == "/upcase") { words[i] = "";   }
                Console.Write(words[i]);
            }
            Console.WriteLine();
        }
    }
}
