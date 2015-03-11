using System;

//Problem 2. Print Company Information

//  A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//  Write a program that reads the information about a company and its manager and prints it back on the console.

namespace ConsoleApplication1
{
    class CompanyName
    {
        static void Main()
        {
            //Company information
            string compName, address, web, fax;
            int phone; //Fax
            //Manager ingormation
            string mFName, mLName;
            int age, mPhone;

            //Get`s Companies data;
            Console.WriteLine("Enter company information");
            Console.WriteLine("Comapny name: ");
            compName = Console.ReadLine();
            Console.WriteLine("Company address: ");
            address = Console.ReadLine();
            Console.WriteLine("Companies phone number: ");
            bool isPhone = int.TryParse(Console.ReadLine(), out phone);
            Console.WriteLine("Companies fax number: ");
            fax = Console.ReadLine();
            //bool isFax   = int.TryParse(Console.ReadLine(), out fax);
            Console.WriteLine("Companies web site: ");
            web = Console.ReadLine();
            //Get`s Manager data
            Console.WriteLine("Manager First name: ");
            mFName = Console.ReadLine();
            Console.WriteLine("Manager Last name: ");
            mLName = Console.ReadLine();
            Console.WriteLine("Manager age: ");
            bool isAge = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Manager phone number: ");
            bool isMPhone = int.TryParse(Console.ReadLine(), out mPhone);

            //Print to console
            if (isAge && isMPhone && isPhone && compName.Length > 2 && address.Length > 2 && web.Length > 2 && mFName.Length > 2 && mLName.Length > 2  )
            {
                if (fax.Length < 2)
                {
                    fax = "( no fax )";
                }
                Console.WriteLine("\n");
                Console.WriteLine(compName + "\nAddress: " + address + "\nTel: " + phone + "\nFax" + "\n" + web +
                    "\nManager" + mFName + " " + mLName + "( age: " + age + ", tel: " + mPhone + " )");
            }

        }
    }
}
