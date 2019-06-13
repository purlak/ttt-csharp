using System;

namespace tictactoe
{
    public class Board

    {
        private DisplayText displayText;
        public string[] cells = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public Board()
        {
            displayText = new DisplayText();
        }
        public void DisplayBoard()
        {
            displayText.Call($" {cells[0]} | {cells[1]} | {cells[2]} ");
            displayText.Call("-----------");
            displayText.Call($" {cells[3]} | {cells[4]} | {cells[5]} ");
            displayText.Call("-----------");
            displayText.Call($" {cells[6]} | {cells[7]} | {cells[8]} ");
        }

        public string UpdateBoard(int input, HumanPlayer currentPlayer)
        {
            return cells[input - 1] = currentPlayer.marker;
        }
    }
}
