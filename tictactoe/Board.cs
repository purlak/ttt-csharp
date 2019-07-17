namespace tictactoe
{
    public class Board
    {
        public string[] cells = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public void UpdateBoard(int position, Player player)
        {
            cells[position - 1] = player._marker;
        }
    }
}