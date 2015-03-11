using System;
/*Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/
namespace _18.ExtractE_mails
{
    class Extract
    {
        static void Main()
        {
            Console.WriteLine("Enter text with E-mails init");
            string str = Console.ReadLine();
            string searchForThis = "@";
            int counter = 1;
            //Default value
            if (str.Length < 3) {    str = "asdasdasd asdsad asd\"123@abv.bg\"ads \"456@abv.bg\" fds.";  }
            string[] email = str.Split('"');
            Console.WriteLine("E-Mails: \n");
            foreach (string val in email)
            {
                int IsX = val.IndexOf(searchForThis);
                if (IsX != -1)
                {
                    Console.WriteLine("{0}. E-Mail:  {1}",counter,val);
                    IsX = 0;
                    ++counter;
                }
            }


        }
    }
}
