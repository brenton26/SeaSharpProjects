using System;
using System.Collections.Generic;

namespace Casino
{
    public abstract class Game //The abstract keyword defines a class that cannot be instantiated, only inherited from
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } = new Dictionary<Player, int>();

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
