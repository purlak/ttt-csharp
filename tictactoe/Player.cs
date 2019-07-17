using System;

namespace tictactoe
{
    public class Player
    {
        public string _marker;
        private IUserInterface _console;

        public Player(string marker, IUserInterface console)
        {
            _marker = marker;
            _console = console;
        }

        public virtual int GetMove(Board board)
        {
            _console.DisplayText(Resources.EnterPosition);

            return Int32.Parse(_console.GetInput());
        }
    }
}