using System;

namespace SnakeAndLadder
{
    /// <summary>
    /// Main class for the game
    /// </summary>
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loggging sample");
            //Created object of SnakeNLadder  Class
            SnakeNLadder snakeNLadder = new SnakeNLadder();
            //Calls StartGame() method
            snakeNLadder.StartGame();
        }


    }
}
