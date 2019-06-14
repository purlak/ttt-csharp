using System;

namespace tictactoe
{
    public class Board 

    {
        private IUserInterface _console;
        public string[] cells = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public Board(IUserInterface console)
        {
            _console = console;
        }

        public void DisplayBoard()
        {
            _console.Call($" {cells[0]} | {cells[1]} | {cells[2]} ");
            _console.Call("-----------");
            _console.Call($" {cells[3]} | {cells[4]} | {cells[5]} ");
            _console.Call("-----------");
            _console.Call($" {cells[6]} | {cells[7]} | {cells[8]} ");
        }

        public void UpdateBoard(int input, HumanPlayer currentPlayer)
        {
            cells[input - 1] = currentPlayer.marker;
        }
    }
}
