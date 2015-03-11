using System;
/*Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.*/

namespace _01.Say_Hello
{
    class Hello
    {
        static void UserName()
        {
            Console.WriteLine("What is Your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            UserName();
        }
    }
}
