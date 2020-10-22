using System;

namespace SnakeAndLadder
{
    class MainClass
    {
        public const int WIN_POINT = 100;
        static void Main(string[] args)
        {
            MainClass start = new MainClass();
            start.StartGame();
        }

        public void StartGame()
        {
            ///Single player with start position at 0
            int player1 = 0, diceValue = 0;
            int player1DieCount = 0;
            while (true)
            {
                diceValue = RollDice();
                player1DieCount++;
                player1 = CalculatePlayerPostion(player1, diceValue);
                Console.WriteLine("Player position 1: " + player1);
                if (player1 == WIN_POINT)
                {
                    Console.WriteLine("Player1 Won");
                    Console.WriteLine("Die rolled " + player1DieCount + " times to win");
                    break;
                }
            }
           

        }

        public int RollDice()
        {
            int n;
            Random random = new Random();
            n = random.Next(7);
            return (n == 0 ? 1 : n);
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
            else if (player1 > WIN_POINT)
            {
                player1 = player1 - diceValue;
            }
            return player1;
        }


    }
}
