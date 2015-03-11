using System;

//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face:
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
//and prints “yes” if it is a valid card sign or “no” otherwise.

namespace Check_for_a_Play_Card
{
    class CheckCard
    {
        static void Main()
        {
            string enterCard;
            Console.Write("Enter some the Play cards: {0}");
            enterCard = Console.ReadLine();
            if (enterCard.Trim().Length > 0 && enterCard.Trim().Length < 3)
            {

            }
        }
    }
}
