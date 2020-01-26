using System;
using System.Collections.Generic;



namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(30);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
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


            //Prints deck to the console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Rank + " of " + card.Suit);
            }
        }
    }
}
