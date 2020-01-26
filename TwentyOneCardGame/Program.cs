using System;
using System.Collections.Generic;



namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Card card1 = new Card();
            Card card2 = card1;
            card1.Rank = Rank.Ace;
            card2.Rank = Rank.Two;
            Console.WriteLine("Card 1: " + card1.Rank);
            Console.WriteLine("Card 2: " + card2.Rank);
            

            //Game game = new TwentyOneGame
            //{
            //    Dealer = "Billy",
            //    Name = "Twenty One",
            //    Players = new List<Player>()
            //};
            //Player player = new Player { Name = "Jimmy" };
            //game += player;
            //game.ListPlayers();

            FullDeck deck = new FullDeck();
            deck.Shuffle(2);


            ////Prints deck to the console
            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Rank + " of " + card.Suit);
            //}
        }
    }
}
