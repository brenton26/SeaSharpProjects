using System;
using System.Collections.Generic;

namespace TwentyOneCardGame
{
    public class FullDeck
    {
        public FullDeck() // Constructor (AKA, method that is called when an object is created)
        {
            Cards = new List<Card>(); //instantiates the property of the class, which is it's cards

            for (int i = 0; i<13; i++)
            {
                for (int j=0; j<4; j++) //For loop runs 52 times
                {
                    Card card = new Card(); //Each time for loop runs, a new instance of card is created
                    card.Rank = (Rank)i; //Casts j (the int value of the enum) to the data type Rank
                    card.Suit = (Suit)j;
                    Cards.Add(card); //Adds each card to the list Cards, which is a property of the deck
                }
            }

            ////From before we made Cards have enum properties instead of string properties
            //List<string> suites = new List<string>()
            //{
            //    "Spades",
            //    "Hearts",
            //    "Clubs",
            //    "Diamonds"
            //};
            //List<string> ranks = new List<string>()
            //{
            //    "Two",
            //    "Three",
            //    "Four",
            //    "Five",
            //    "Six",
            //    "Seven",
            //    "Eight",
            //    "Nine",
            //    "Ten",
            //    "Jack",
            //    "Queen",
            //    "King",
            //    "Ace"
            //};

            //foreach (string suit in suites)
            //{
            //    foreach (string rank in ranks)
            //    {
            //        Card card = new Card();
            //        card.Rank = rank;
            //        card.Suit = suit;
            //        Cards.Add(card);
            //    }
            //}
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
 