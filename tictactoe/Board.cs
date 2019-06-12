namespace tictactoe
{
    public class Board
    {
        string[] cells = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public string[] DisplayBoard()
        {
            DisplayText.Call($" {cells[0]} | {cells[1]} | {cells[2]} ");
            DisplayText.Call("-----------");
            DisplayText.Call($" {cells[3]} | {cells[4]} | {cells[5]} ");
            DisplayText.Call("-----------");
            DisplayText.Call($" {cells[6]} | {cells[7]} | {cells[8]} ");
            return cells;
        }
    }
}
