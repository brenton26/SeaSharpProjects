using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOneCardGame
{
    public class Dealer
    {
        public Dealer()
        {
        }
        public string Name { get; set; }
        public FullDeck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + '\n');
            Deck.Cards.RemoveAt(0);           
        }
    }
}
