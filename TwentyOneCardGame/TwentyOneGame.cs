using System;
namespace TwentyOneCardGame
{
    public class TwentyOneGame : Game //Inherits from the Game class
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
    }
}
