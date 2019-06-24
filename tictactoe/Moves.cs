using System;

namespace tictactoe
{
    public class Moves
    {
        public bool Full(string[] cells)
        {
            bool val = Array.Exists(cells,
                cell =>
                cell == " " ||
                cell == null
               );
            return !val;
        }

        public bool Taken(Board board, int input)
        {
            return (GetPosition(board, input) == "X" || GetPosition(board, input) == "O");
        }

        public string GetPosition(Board board, int input)
        {
            return (board.cells[input - 1]);
        }


    }
}