using System;
/*Problem 20.* Variations of set

Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].*/

namespace _20.VariationOFSet
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(n, k); i++)
            {

                int temp = i;
                int[] num = new int[k];
                for (int j = 0; j < k; j++)
                {
                    num[k - j - 1] = temp % n;
                    temp = temp / n;
                }

                Console.Write("{0}{1}", '{', num[0] + 1);
                for (int j = 1; j < k; j++)
                {
                    Console.Write(", {0}", num[j] + 1);
                }
                Console.Write("}");
                if (i != Math.Pow(n, k) - 1)
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();
        }
    }
}
