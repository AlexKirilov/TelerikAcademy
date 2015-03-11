using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */
namespace _04.Sub_string_in_text
{
    class SubStringInText
    {
        static void Main()
        {

            
            string text, substring;

            Console.WriteLine("Enter the string");
            text = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the sub-string");
            substring = Console.ReadLine().ToLower();

            //Default values
            if (text.Length < 5)    text ="We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. \nSo we are drinking all the day. We will move out of it in 5 days.".ToLower();
            if (substring.Length < 2)    substring = "in";
            
            int counter = 0;
            int index = text.IndexOf(substring);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(substring, index + 1);
            }
            Console.WriteLine("\nSentense is:\n\n\" {0} \"\n", text);
            Console.WriteLine("The sub-string \"{0}\" is {1} times met in the sentence.", substring, counter);

        }
    }
}
