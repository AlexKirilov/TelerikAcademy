using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNT
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = (123456 / (Math.Pow(10, 5)) % 10);
            Console.WriteLine(val);
        }
    }
}
