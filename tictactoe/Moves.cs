using System;
using System.Linq;

namespace tictactoe
{
    public class Moves
    {
        public bool Full(string[] cells)
        {
            return !Array.Exists(cells,
             cell =>
             cell == " " ||
             cell == null
            );
        }

        public bool Taken(Board board, int input)
        {
            return (GetPosition(board, input) == "X" || GetPosition(board, input) == "O");
        }

        public bool ValidMove(Board board, int input)
        {
            return Between(input) && !Taken(board, input);
        }

        public string GetPosition(Board board, int input)
        {
            return (board.cells[input - 1]);
        }

        public int TurnCount(string[] cells)
        {
            return (cells.Count(cell => cell == "X" || cell == "O"));
        }

        public bool Between(int input)
        {
            return 1 <= input && input <= 9;
        }
    }
}