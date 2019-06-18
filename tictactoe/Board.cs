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
            _console.DisplayText($" {cells[0]} | {cells[1]} | {cells[2]} ");
            _console.DisplayText("-----------");
            _console.DisplayText($" {cells[3]} | {cells[4]} | {cells[5]} ");
            _console.DisplayText("-----------");
            _console.DisplayText($" {cells[6]} | {cells[7]} | {cells[8]} ");
        }
    }
}