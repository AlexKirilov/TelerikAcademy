using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Problem 5. Boolean Variable

    Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    Print it on the console.
 */
namespace BoolVal
{
    class BoolVal
    {
        static void Main()
        {
            bool isFemale = true;

            Console.WriteLine("Please enter you gender");
            string sex = Console.ReadLine();
            
            if (sex != "Female" && sex != "female" && sex != "f" && sex != "F") isFemale = false; ;

            Console.WriteLine("Your gender is Female: That`s " + isFemale);
        }
    }
}
