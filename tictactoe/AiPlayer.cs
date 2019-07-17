using System;

namespace tictactoe
{
    public class AiPlayer : Player
    {
        new private string _marker;
        public int aiInput = 1;
        private Moves moves;

        public AiPlayer(string marker, IUserInterface console) : base(marker, console)
        {
            _marker = marker;
            moves = new Moves();
        }

        public override int GetMove(Board board)
        {
            Random cells = new Random();
            do
            {
                aiInput = cells.Next(1, 9);
            }
            while (!moves.ValidMove(board, aiInput));

            return aiInput;
        }
    }
}