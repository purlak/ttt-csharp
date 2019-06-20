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

        public void UpdateBoard(int position, Player player)
        {
            cells[position - 1] = player._marker;
        }
    }
}