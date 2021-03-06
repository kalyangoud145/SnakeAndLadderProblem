﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    /// <summary>
    /// Class for implementing snake and ladder game
    /// </summary>
    class SnakeNLadder
    {
        //Constant
        public const int WIN_POINT = 100;
        NLog nLog = new NLog();
        public void StartGame()
        {
            //Two players with start position at 0
            int player1 = 0, diceValue;
            //For counting number of times die rolled
            int player1DieCount = 0, player2DieCount = 0;
            int currentPlayer = -1;
            int player2 = 0;

            while (true)
            {
                diceValue = RollDice();
                if (currentPlayer == -1)
                {
                    //Increments player count every time loop executes
                    player1DieCount++;
                    //calls CalculatePlayerPostion() and gets player position
                    player1 = CalculatePlayerPostion(player1, diceValue);
                    //Prints players position
                    Console.WriteLine("Player position 1: " + player1);
                    Console.WriteLine("Player position 2: " + player2);
                    //Checks if player position is equal to 100 
                    if (player1 == WIN_POINT)
                    {
                        //Prints player won
                        Console.WriteLine("Player1 Won");
                        nLog.LogDebug("Debug successfully: StartGame()");
                        nLog.LogInfo("CalculatePlayerPostion() passed.." + player1);
                        //Prints number of time die rolled to win
                        Console.WriteLine("Die rolled " + player1DieCount + " times to win");
                        break;
                    }
                }
                else
                {
                    //Increments player count every time loop executes
                    player2DieCount++;
                    //calls CalculatePlayerPostion() and gets player position
                    player2 = CalculatePlayerPostion(player2, diceValue);
                    //Prints players position
                    Console.WriteLine("Player position 2: " + player2);
                    Console.WriteLine("Player position 1: " + player1);
                    //Checks if player position is equal to 100
                    if (player2 == WIN_POINT)
                    {
                        Console.WriteLine("Player2 Won");
                        nLog.LogDebug("Debug successfully: StartGame()");
                        nLog.LogInfo("CalculatePlayerPostion() passed.." + player2);
                        //Prints number of time die rolled to win
                        Console.WriteLine("Die rolled " + player1DieCount + " times to win");
                        break;
                    }
                }
                //Changes currentPlayer for switching between two players
                currentPlayer = -(currentPlayer);

            }


        }
        /// <summary>
        /// Method return a number from 1 to 6
        /// </summary>
        public int RollDice()
        {
            int n;
            Random random = new Random();
            n = random.Next(7);
            return (n == 0 ? 1 : n);
        }
        /// <summary>
        /// Calculates the Respective players postion.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="diceValue">The dice value.</param>
        /// <returns></returns>
        public int CalculatePlayerPostion(int player, int diceValue)
        {
            int x;
            Random random = new Random();
            x = random.Next(3);
            //Switch selects the player next move based on random number
            switch (x)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    Console.WriteLine("Ladder");
                    player = player + diceValue;
                    Console.WriteLine("Rolling die again");
                    diceValue = RollDice();
                    player = player + diceValue;
                    break;
                default:
                    Console.WriteLine("Snake");
                    player = player - diceValue;
                    break;
            }
            //If player  position less than 0 the player positon will be reset to 0
            if (player < 0)
            {
                player = 0;
            }
            //if player positon is greater than 100 then the player remains in same position
            else if (player > WIN_POINT)
            {
                player = player - diceValue;
            }
            return player;
        }

    }
}
