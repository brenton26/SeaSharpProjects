using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public class TwentyOneGame : Game, IWalkAway //Inherits from the Game class and the IWalkAway interface
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new FullDeck();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            Console.WriteLine("");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotSupportedException();
        }
    }
}
