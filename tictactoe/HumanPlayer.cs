using System;

namespace tictactoe
{
    public class HumanPlayer
    {
        public string marker;
        private DisplayText displayText;

        public HumanPlayer(string _marker)
        {
            marker = _marker;
            displayText = new DisplayText();
        }

        public string Move(Board board)
        {
            displayText.Call(Content.GetPosition());
            string input = Console.ReadLine();
            return input;
        }
    }
}
