using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public abstract class Game //The abstract keyword defines a class that cannot be instantiated, only inherited from
    {
        public Game()
        {
        }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //Any class that inherits from this class MUST define this method (An abstract method)

        public virtual void ListPlayers() //Virtual means that this method gets inherited by inheriting classes, but, the inheriting class has the ability to override it
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
