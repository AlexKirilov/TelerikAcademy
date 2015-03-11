using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
 */
namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse( charArray );
            str = new string(charArray);
            Console.WriteLine(str);
        }
    }
}
