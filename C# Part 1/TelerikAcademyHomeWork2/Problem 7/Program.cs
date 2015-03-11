using System;
/*
 * Problem 7. Quotes in Strings

    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    Do the above in two different ways - with and without using quoted strings.
    Print the variables to ensure that their value was correctly defined.
*/
namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string try1 = "The \"use\" of quotations causes difficulties.";
            string try2 = @"The ""use"" of quotations causes difficulties";
            //LMO
            string try3 = try1;
            Console.Write(try1 + "\n" + try2 + "\n" + try3 + "\n");
            string string1 = @"The ""use"" of quotations causes difficulties";
            Console.Write(string1);
            
        }
    }
}
