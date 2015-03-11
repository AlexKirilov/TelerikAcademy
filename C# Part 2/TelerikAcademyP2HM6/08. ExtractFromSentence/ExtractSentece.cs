using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.*/
namespace _08.ExtractFromSentence
{
    class ExtractSentece
    {
        static void Main()
        {  
            Console.WriteLine("Enter some text");
            string str = Console.ReadLine();
            Console.WriteLine("Enter looking word");
            string search = Console.ReadLine();
            //Default values
            if (str.Length < 10)        { str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; }
            if (search.Length == 0)     { search = "in";}
            bool isForPrint = false;

            string[] strSentence = str.Split('.' , '!' , '?');
            
            for (int row = 0; row < strSentence.Length; row++)
            {
                string[] subSentence = strSentence[row].Split(' ');
                for (int words = 0; words < subSentence.Length; words++)
                {
                    if (subSentence[words] == search)
                    {
                        isForPrint = true;
                    }
                }
                if (isForPrint)
                {
                    Console.Write(strSentence[row] + ".");
                    isForPrint = false;
                }
            }
            Console.WriteLine();
        }
    }
}
