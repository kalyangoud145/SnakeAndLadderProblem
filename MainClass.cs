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

        public void StartGame()
        {
            ///Single player with start position at 0
            int player1 = 0;

        }

        public int CalculatePlayerPostion(int player1, int diceValue)
        {
            int x;
            Random random = new Random();
            x = random.Next(3);
            switch (x)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Ladder");
                    player1 = player1 + diceValue;
                    break;
                default:
                    Console.WriteLine("Snake");
                    player1 = player1 - diceValue;
                    break;
            }

            if (player1 < 0)
            {
                player1 = 0;
            }
            else if (player1 > 100)
            {
                player1 = player1 - diceValue;
            }
            return player1;
        }


    }
}
