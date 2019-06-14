using System;

namespace tictactoe
{
    public class Game
    {
        private Board board;
        private HumanPlayer player1;
        private HumanPlayer player2;
        private GameRules rules;
        private DisplayText displayText;
        private HumanPlayer currentPlayer;
        private Moves moves;

        public Game()
        {
            board = new Board();
            rules = new GameRules();
            moves = new Moves();
            displayText = new DisplayText();
            currentPlayer = new HumanPlayer("X");
        }
       
        public void Play()
        {
            board.DisplayBoard();
            GetPlayers();
            do
            {
                Turn();
            } while(rules.Over(board) != true);

            if (rules.Draw(board))
            {
                displayText.Call(Content.GameDraws());
            }
            else if (rules.Won(board))
            {
                displayText.Call(Content.GameOver(currentPlayer.marker));
            } 
        }

        public void Turn()
        {
            CurrentPlayer();
            displayText.Call(Content.Turn(currentPlayer.marker));
            int input = Int32.Parse(currentPlayer.Move(board));
            if (moves.ValidMove(board, input))
            {
                board.UpdateBoard(input, currentPlayer);
                board.DisplayBoard();
            }
            else if (moves.Between(input) == false)
            {
                displayText.Call(Content.InvalidMove());
                CurrentPlayer();
                Turn();
            }

            else if (moves.Taken(board, input))
            {
                displayText.Call(Content.Taken());
                CurrentPlayer();
                Turn();

            }
        }

        public void GetPlayers()
        {
            player1 = new HumanPlayer("X");
            player2 = new HumanPlayer("O");
        }

        public HumanPlayer CurrentPlayer()
        {
            if (moves.TurnCount(board.cells)% 2 == 0)
            {
                currentPlayer = player1;
            }
            else
            {
                currentPlayer = player2;
            }
            return currentPlayer;
        }
    }
}
