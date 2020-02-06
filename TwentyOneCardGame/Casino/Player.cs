using System;
using System.Collections.Generic;

namespace Casino
{
    public class Player
    {
        public Player(string name) : this(name, 100) { }
        public Player(string name, int starting_balance)
        {
            Name = name;
            Balance = starting_balance;
            Hand = new List<Card>();
        }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough money to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true; // Might need to delete this?
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
