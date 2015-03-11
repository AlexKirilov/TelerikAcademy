using System;
using System.Globalization;
using System.Threading;
/*Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/
namespace _19.DateFromTextInCanada
{
    class DateInCanada
    {
        static void Main()
        {
            Console.WriteLine("Enter sentence with data");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                    CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                }
                catch (FormatException)
                {
                }
            }
        }
    }
}
