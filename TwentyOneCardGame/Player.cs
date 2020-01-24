using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public class Player
    {
        public Player()
        {
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


    }
}
