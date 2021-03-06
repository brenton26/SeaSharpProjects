﻿using System;

namespace Casino
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Rank, Suit);
        }
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
