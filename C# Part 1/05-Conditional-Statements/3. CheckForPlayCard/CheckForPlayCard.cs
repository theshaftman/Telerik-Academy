using System;

class CheckForPlayCard
{
    /*	Classical play cards use the following signs to designate the card 
    face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that 
    enters a string and prints “yes” if it is a valid card sign or “no” otherwise. */

    static void Main()
    {
        string[] playCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("Write character to check: ");
        string playCard = Console.ReadLine();
        bool validCard = false;

        for (int i = 0; i < playCards.Length; i++)
        {
            if (playCards[i].Equals(playCard))
            {
                validCard = true;
            }
        }

        Console.WriteLine("Valid card sign?: {0}\n", validCard ? "yes" : "no");

        Main();
    }
}
