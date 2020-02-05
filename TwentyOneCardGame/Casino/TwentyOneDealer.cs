using System;
using System.Collections.Generic;

namespace Casino.TwentyOneCardGame
{
    public class TwentyOneDealer : Dealer
    {
        public bool Stay { get; set; }
        public bool IsBusted  { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
    }
}

