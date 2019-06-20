using System;

namespace tictactoe
{
    public class Player
    {
        public string _marker;
        public IUserInterface _console;

        public Player(string marker, IUserInterface console)
        {
            _marker = marker;
            _console = console;
        }

        public int GetMove()
        {
            _console.DisplayText("Enter Board Position [1-9]: ");

            return Int32.Parse(_console.GetInput());
        }
    }
}