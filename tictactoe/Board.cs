namespace tictactoe
{
    public class Board

    {
        private DisplayText displayText;
        string[] cells = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

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
            //return cells;
        }
    }
}
