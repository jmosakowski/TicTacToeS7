using System;

namespace TicTacToeS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two boards - with starting and with current fields
            char[,] startBoard = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };
            char[,] gameBoard = startBoard.Clone() as char[,];

            // Flags
            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true; // true - player 1 move, false - player 2 move
            
            ////////////////////////////////////////////////////////////////
            
            // Loop over rounds
            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                // TODO: draw the board
                
                if (nextIsPlayer1)
                {
                    // TODO: player 1 move
                    nextIsPlayer1 = false;
                }
                else
                {
                    // TODO: player 2 move
                    nextIsPlayer1 = true;
                }
                
                if (player1Won || player2Won)
                    break;
            }
            
            ////////////////////////////////////////////////////////////////
            
            // End the game
            Console.Clear();
            // TODO: draw the board
            Console.Write("Game ended! ");
            // TODO: print who won
        }
    }
}
