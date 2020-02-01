using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOneCardGame
{
    public class TwentyOneRules
    {
        private static Dictionary<Rank, int> _cardValues = new Dictionary<Rank, int>() // underscore before the name is a convention for private classes
        {
            [Rank.Two] = 2,
            [Rank.Three] = 3,
            [Rank.Four] = 4,
            [Rank.Five] = 5,
            [Rank.Six] = 6,
            [Rank.Seven] = 7,
            [Rank.Eight] = 8,
            [Rank.Nine] = 9,
            [Rank.Ten] = 10,
            [Rank.Jack] = 10,
            [Rank.Queen] = 10,
            [Rank.King] = 10,
            [Rank.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int ace_count = Hand.Count(x => x.Rank == Rank.Ace);
            int[] result = new int[ace_count + 1];
            int value = Hand.Sum(x => _cardValues[x.Rank]);
            result[0] = value;
            if (result.Length == 1) return result;
            for (int i=1; i<result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possible_values = GetAllPossibleHandValues(Hand);
            int value = possible_values.Max();
            if (value == 21) return true;
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possible_hand_values = GetAllPossibleHandValues(Hand);
            foreach (int value in possible_hand_values)
            {
                if (value > 16 && value < 22) return true;
            }
            return false;
        }
        public static bool? CompareHands(List<Card> player_hand, List<Card> dealer_hand)
        {
            int[] player_results = GetAllPossibleHandValues(player_hand);
            int[] dealer_results = GetAllPossibleHandValues(dealer_hand);
            int player_score = player_results.Where(x => x < 22).Max();
            int dealer_score = dealer_results.Where(x => x < 22).Max();
            if (player_score > dealer_score) return true;
            else if (player_score < dealer_score) return false;
            else return null;
        }
    }
}
