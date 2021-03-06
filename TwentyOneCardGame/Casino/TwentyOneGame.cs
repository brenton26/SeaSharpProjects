﻿using System;
using System.Collections.Generic;
using System.Linq;
using Casino.Interfaces;

namespace Casino.TwentyOneCardGame
{
    public class TwentyOneGame : Game, IWalkAway //Inherits from the Game class and the IWalkAway interface
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new FullDeck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool valid_answer = false;
                int bet = 0;
                while (!valid_answer)
                {
                    Console.WriteLine("Place your bet!");
                    valid_answer = int.TryParse(Console.ReadLine(), out bet);
                    if (!valid_answer) { Console.WriteLine("Please enter digits only."); }
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfully_bet = player.Bet(bet);
                if (!successfully_bet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i=0; i<2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackjack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackjack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackjack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackjack)
                    {
                        Console.WriteLine("Dealer has blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.",
                            player.Name,
                            Bets[player],
                            player.Balance);
                        Console.Write("Do you want to play again?: ");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                        {
                            player.IsActive = true;
                            return;
                        }
                        else
                        {
                            player.IsActive = false;
                            return;
                        }
                    }
                }
            }
            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.IsBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay) Console.WriteLine("Dealer is staying.");
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? player_won = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (player_won == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (player_won == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.Write("Play again?: ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "ya" || answer == "yeah" || answer == "y")
                {
                    player.IsActive = true;
                }
                else
                {
                    player.IsActive = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            Console.WriteLine("");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotSupportedException();
        }
    }
}
