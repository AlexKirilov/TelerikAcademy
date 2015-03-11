using System;

/*
 Problem 6. Strings and Objects

    Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */
namespace Problem_6_HM2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello", str2 = "World";
            object result = str1 +" "+ str2;
            string str3 = result.ToString();

            Console.WriteLine(str3);
        }
    }
}
