using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 01.Allocate array
{
    class Array
    {
        static void Main()
        {

            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = 5 * i;
                Console.WriteLine("{0} , {1}", array[i], i);
            }

        }
    }
}
