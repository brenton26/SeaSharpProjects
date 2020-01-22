using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public class FullDeck
    {
        public FullDeck() // Constructor (AKA, method that is called when an object is created)
        {
            Cards = new List<Card>(); //instantiates the property of the class, which is it's cards

            List<string> suites = new List<string>()
            {
                "Spades",
                "Hearts",
                "Clubs",
                "Diamonds"
            };
            List<string> ranks = new List<string>()
            {
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine",
                "Ten",
                "Jack",
                "Queen",
                "King",
                "Ace"
            };

            foreach (string suit in suites)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card();
                    card.Rank = rank;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }
        }       
        public List<Card> Cards { get; set; } //Class Properties

        public void Shuffle(int number_of_shuffles = 1)
        {
            for (int i = 0; i < number_of_shuffles; i++)
            {
                List<Card> temp_list = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    int random_index = random.Next(0, Cards.Count);
                    temp_list.Add(Cards[random_index]);
                    Cards.RemoveAt(random_index);
                }
                Cards = temp_list;
            }
        }
    }
}
 