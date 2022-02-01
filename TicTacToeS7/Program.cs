using System;

namespace TicTacToeS7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two players
            HumanPlayer p1 = new HumanPlayer();
            ComputerPlayer p2 = new ComputerPlayer();
            p1.Name = "JacekM";
            p2.Name = "AI";
            p1.Symbol = 'x';
            p2.Symbol = 'o';

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
                Draw(gameBoard);

                if (nextIsPlayer1)
                {
                    Console.WriteLine(p1.Name + " move");
                    player1Won = p1.MakeMove(startBoard, gameBoard);
                    nextIsPlayer1 = false;
                }
                else
                {
                    Console.WriteLine(p2.Name + " move");
                    player2Won = p2.MakeMove(startBoard, gameBoard);
                    nextIsPlayer1 = true;
                }

                if (player1Won || player2Won)
                    break;
            }

            ////////////////////////////////////////////////////////////////

            // End the game
            Console.Clear();
            Draw(gameBoard);
            Console.Write("Game ended! ");
            if (player1Won)
                Console.WriteLine("Winner: " + p1.Name);
            else if (player2Won)
                Console.WriteLine("Winner: " + p2.Name);
            else
                Console.WriteLine("A tie!");
        }

        /******************************************************************/

        static void Draw(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                    Console.Write(board[i, j]);
                Console.WriteLine();
            }
        }
    }
}
