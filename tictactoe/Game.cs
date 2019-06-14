using System;

namespace tictactoe
{
    public class Game
    {
        private Board board;
        private HumanPlayer player1;
        private HumanPlayer player2;
        private GameRules rules;
        private ConsoleInterface console;
        private HumanPlayer currentPlayer;
        private Moves moves;

        public Game()
        {
            console = new ConsoleInterface();
            board = new Board(console);
            rules = new GameRules();
            moves = new Moves();
            currentPlayer = new HumanPlayer("X");
        }

        public void Play()
        {
            board.DisplayBoard();
            GetPlayers();
            do
            {
                Turn();
            } while (rules.Over(board) != true);

            if (rules.Draw(board))
            {
                console.Call(Content.GameDraws());
            }
            else if (rules.Won(board))
            {
                console.Call(Content.GameOver(currentPlayer.marker));
            }
        }

        public void Turn()
        {
            CurrentPlayer();
            console.Call(Content.Turn(currentPlayer.marker));
            int input = Int32.Parse(currentPlayer.Move(board));
            if (moves.ValidMove(board, input))
            {
                board.UpdateBoard(input, currentPlayer);
                board.DisplayBoard();
            }
            else if (moves.Between(input) == false)
            {
                console.Call(Content.InvalidMove());
                CurrentPlayer();
                Turn();
            }

            else if (moves.Taken(board, input))
            {
                console.Call(Content.Taken());
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
            if (moves.TurnCount(board.cells) % 2 == 0)
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
