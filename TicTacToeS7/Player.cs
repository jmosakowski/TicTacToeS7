using System;

namespace TicTacToeS7
{
    interface IMoving
    {
        bool MakeMove(char[,] startBoard, char[,] gameBoard);
    }

    /**********************************************************************/

    abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public bool CheckIfPlayerWon(char[,] gameBoard)
        {
            int height = gameBoard.GetLength(0);
            int width = gameBoard.GetLength(1);
            if (height != width)
                throw new Exception("The board is not square!");
            
            // Check rows
            for (int i = 0; i < height; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < width; j++)
                {
                    if (gameBoard[i, j] == Symbol)
                        rowSum++;
                }
                if (rowSum == width)
                    return true;
            }
            
            // Check columns
            for (int j = 0; j < width; j++)
            {
                int colSum = 0;
                for (int i = 0; i < height; i++)
                {
                    if (gameBoard[i, j] == Symbol)
                        colSum++;
                }
                if (colSum == height)
                    return true;
            }
            
            // Check diagonals
            int diagSumA = 0;
            int diagSumB = 0;
            for (int k = 0; k < width; k++)
            {
                if (gameBoard[k, k] == Symbol)
                    diagSumA++;
                if (gameBoard[k, width - 1 - k] == Symbol)
                    diagSumB++;
            }
            if (diagSumA == width || diagSumB == width)
                return true;
            
            // Otherwise, no win yet
            return false;
        }
    }

    /**********************************************************************/

    class HumanPlayer : Player, IMoving
    {
        public bool MakeMove(char[,] startBoard, char[,] gameBoard)
        {
            // TODO: human move
            return CheckIfPlayerWon(gameBoard);
        }
    }

    /**********************************************************************/

    class ComputerPlayer : Player, IMoving
    {
        public bool MakeMove(char[,] startBoard, char[,] gameBoard)
        {
            // TODO: computer move
            return CheckIfPlayerWon(gameBoard);
        }
    }
}
