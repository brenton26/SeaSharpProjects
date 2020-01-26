using System;
namespace TwentyOneCardGame
{
    public class TwentyOneGame : Game, IWalkAway //Inherits from the Game class and the IWalkAway interface
    {
        public TwentyOneGame()
        {
        }

        public override void Play()
        {
            throw new NotImplementedException();
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
