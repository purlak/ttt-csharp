using System;

namespace tictactoe
{
    public class HumanPlayer
    {
        public string marker;
        private ConsoleInterface console;

        public HumanPlayer(string _marker)
        {
            marker = _marker;
            console = new ConsoleInterface();
        }

        public string Move(Board board)
        {
            console.Call(Content.GetPosition());
            string input = console.GetInput();
            return input;
        }
    }
}
