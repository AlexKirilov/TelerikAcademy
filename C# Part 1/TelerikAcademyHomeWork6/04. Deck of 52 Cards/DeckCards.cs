using System;


//Problem 4. Print a Deck of 52 Cards

//  Write a program that generates and prints all possible cards from a standard deck of 52 cards
//  (without the jokers). The cards should be printed using the classical notation 
//  (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//  The card faces should start from 2 to A.
//  Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//  Use 2 nested for-loops and a switch-case statement.

namespace Deck_of_52_Cards
{
    class DeckCards
    {
        static void Main()
        {
            string cardName = " ", num = " ";// Default string;
            int cardNum;
            Console.WriteLine("This is a full Deck Cards\n");
            for (int i = 1; i < 14; i++)
            {
                //Number of the card
                cardNum = i+1;
                num = cardNum.ToString();
                if (cardNum >= 11)
                {
                    switch (cardNum)
                    {
                        case 11: num = "J"; break;
                        case 12: num = "Q"; break;
                        case 13: num = "K"; break;
                        case 14: num = "A"; break;
                    }
                }
                //type of the cards
                for (int y = 1; y < 5; y++)
                {
                    switch (y)
                    {
                        case 1: cardName = "spades"; break;
                        case 2: cardName = "clubs"; break;
                        case 3: cardName = "hearts"; break;
                        case 4: cardName = "diamonds"; break;
                    }
                    //Printing the cards
                    Console.Write("{0} of {1}, ", num, cardName);
                }
                Console.WriteLine("\n"); // New row
            }
        }
    }
}
