using System;

namespace MoreLess
{
    class Program : Game
    {
        static void Main(string[] args)
        {
            var userGame = new Game();
            userGame.BeginGame();
        }
    }
}