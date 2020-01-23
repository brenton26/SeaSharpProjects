using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public class Game
    {
        public Game()
        {
        }

        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
                Console.WriteLine();
            }
        }
    }
}
