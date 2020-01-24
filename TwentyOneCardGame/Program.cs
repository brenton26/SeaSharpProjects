using System;
using System.Collections.Generic;



namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame
            {
                Dealer = "Billy",
                Name = "Twenty One",
                Players = new List<string>()
                {
                    "Billy",
                    "Fred",
                    "Ebeneezer",
                    "George"
                }
            };
            game.ListPlayers();

            //FullDeck deck = new FullDeck();
            //deck.Shuffle(2);


            ////Prints deck to the console
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Rank + " of " + card.Suit);
            //}
        }
    }
}
