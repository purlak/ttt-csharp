namespace tictactoe
{
    public class AiPlayer : Player
    {
        new public string _marker;
        private int input;

        public AiPlayer(string marker, IUserInterface console) : base(marker, console)
        {
            _marker = marker;
        }

        public override int GetMove(Board board)
        {
            if (Center(board))
            {
                input = 5;
            }
            return input;
        }

        private bool Center(Board board)
        {
            if (board.cells[4] == " ")
            {
                return true;
            }
            return false;
        }
    }
}