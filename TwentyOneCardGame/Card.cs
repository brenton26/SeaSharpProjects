using System;
namespace TwentyOneCardGame
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }
    public enum Suit
    {
        Spades,
        Hearts,
        Clubs,
        Diamonds
    }
    public enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
