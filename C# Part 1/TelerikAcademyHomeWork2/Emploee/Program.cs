using System;
/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
 */
namespace Emploee
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Aleksandar", lName = "Kirilov";
            short age = 27;
            char sex = 'm';
            long IDnum = 8306112507;
            ulong UniEmpNum = 2756000027569999;

            Console.WriteLine("Employee data base: \n");
            Console.WriteLine("Full name:       " + fName + " " + lName);
            Console.WriteLine("Age:             " + age);
            Console.WriteLine("Gender:          " + sex);
            Console.WriteLine("Personal ID:     " + IDnum);
            Console.WriteLine("Employee number: " + UniEmpNum + "\n");
        }
    }
}
