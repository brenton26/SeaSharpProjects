using System;
using System.Collections.Generic;



namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            FullDeck deck = new FullDeck();            
            deck.Shuffle(10);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }

            Console.WriteLine("");
        }
    }
}
