using System;

namespace SnakeAndLadder
{
    class MainClass
    {
        static void Main(string[] args)
        {
            MainClass start = new MainClass();
            start.StartGame();
        }
        
        public  void StartGame()
        {
            ///Single player with start position at 0
            int player1 = 0;
            Console.WriteLine(RollDice());
        }

        public int RollDice()
        {
            int n ;
            Random random = new Random();
            n = random.Next(7);
            return (n == 0 ? 1 : n);
        }
    }
}
