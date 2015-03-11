using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumber
{
    class FormatNumb
    {
        static void Main()
        {
            bool correct = false;
            int input = 0;
            Console.Write("Enter integer number: ");
            while (!correct)
            {
                correct = int.TryParse(Console.ReadLine(), out input);
                if (!correct)
                    Console.WriteLine("Incorrect input. Try again");
            }
            Console.WriteLine("Formating numbers:\n");

            Console.WriteLine("Decimal    :{0}", input.ToString("D").PadLeft(15));
            Console.WriteLine("Hexaecimal :{0}", ("0x" + input.ToString("X")).PadLeft(15));
            Console.WriteLine("Percentage :{0}", (input.ToString("P0")).PadLeft(15));
            Console.WriteLine("Scientific :{0}", (input.ToString("E2")).PadLeft(15));
            
        }
    }
}
