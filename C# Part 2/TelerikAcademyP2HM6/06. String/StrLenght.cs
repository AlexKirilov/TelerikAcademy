using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.*/
namespace _06.СтрингЛенгхт
{
    class StrLenght
    {
        static void Main()
        {
            char symbol = '*';
            Console.WriteLine("Enter some string with MAX lenght 20 symbols");
            string str = Console.ReadLine();
            if (str.Length <= 20)
            {
                Console.WriteLine("\n"+ str.PadRight(20, symbol));
            }
            else { 
                str = str.Substring(0, 20);
                Console.WriteLine("\n"+ str);
            }
        }
    }
}
