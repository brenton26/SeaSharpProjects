using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("Welcome to Ed's fabulous 21 game!");
            Console.Write("Let's start by you telling me your name: ");
            string player_name = Console.ReadLine();
            Console.Write("And how much money did you bring today: ");
            int player_money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hello {0}, would you like to join a game of 21 right now?: ", player_name);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "yup" || answer == "ya")
            {
                Player player = new Player(player_name, player_money);

                Game game = new TwentyOneGame();
                game += player;
                player.IsActive = true;

                while (player.IsActive && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Goodbye");
        }
          



    //FullDeck deck = new FullDeck();
    //List<Card> kingz = deck.Cards.Where(x => x.Rank == Rank.Jack ).ToList();
    //foreach (Card card in kingz) {
    //    Console.WriteLine(card.Suit);
    //}

    //List<int> my_list = new List<int> { 2, 5, 10, 25, 26, 42, 64, 69 };
    //int my_int = my_list.Sum(x => x*x);
    //Console.WriteLine(my_int);

    //Card card1 = new Card();
    //Card card2 = card1;
    //card1.Rank = Rank.Ace;
    //card2.Rank = Rank.Two;
    //Console.WriteLine("Card 1: " + card1.Rank);
    //Console.WriteLine("Card 2: " + card2.Rank);


    //Game game = new TwentyOneGame
    //{
    //    Dealer = "Billy",
    //    Name = "Twenty One",
    //    Players = new List<Player>()
    //};
    //Player player = new Player { Name = "Jimmy" };
    //game += player;
    //game.ListPlayers();

    //FullDeck deck = new FullDeck();
    //deck.Shuffle(2);


    ////Prints deck to the console
    //foreach (Card card in deck.Cards)
    //{
    //    Console.WriteLine(card.Rank + " of " + card.Suit);
    //}

    }
}
