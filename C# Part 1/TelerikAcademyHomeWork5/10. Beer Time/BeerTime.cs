using System;

//Problem 10.* Beer Time

//  A beer time is after 1:00 PM and before 3:00 AM.
//  Write a program that enters a time in format “hh:mm tt” 
//  (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
//  and prints beer time or non-beer time according to the definition above or invalid time 
//  if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

namespace Beer_Time
{
    class BeerTime
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please enter the curent time in format hh:mm tt");
                try
                {
                    DateTime time = DateTime.Parse(Console.ReadLine());
                    DateTime beerTime = DateTime.Parse("01:00:00 PM");
                    DateTime noBeer = DateTime.Parse("03:00:00 AM");
                    if ((time >= beerTime) || (time < noBeer))
                    {
                        Console.WriteLine("beer time");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid time format ! ");
                }
            }
            

        }
    }
}
