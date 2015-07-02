using System;

class Print52Cards
{
    /*	Write a program that generates and prints all possible cards 
    from a standard deck of 52 cards (without the jokers). The cards 
    should be printed using the classical notation (like 5 of spades, 
    A of hearts, 9 of clubs; and K of diamonds).*/

    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", 
                             "10", "J", "Q", "K", "A" };
        char spades = '\u2660';
        char clubs = '\u2663';
        char hearts = '\u2665';
        char diamonds = '\u2666';

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0: Console.Write("{0}{1}, ", cards[i], spades); break;
                    case 1: Console.Write("{0}{1}, ", cards[i], clubs); break;
                    case 2: Console.Write("{0}{1}, ", cards[i], hearts); break;
                    case 3: Console.Write("{0}{1}", cards[i], diamonds); break;
                }
            }

            Console.WriteLine();
        }
    }
}
