using System;

namespace tictactoe
{
    public class Game
    {
        private IUserInterface _console;
        private Board board;
        private Player player1;
        private Player player2;
        private GameRules rules;
        private Moves moves;
        private Player currentPlayer;

        public Game(IUserInterface console)
        {
            _console = console;
            board = new Board();
            rules = new GameRules();
            moves = new Moves();
            player1 = new Player("X", console);
            player2 = new Player("O", console);
        }

        public Board GetBoard()
        {
            return board;
        }

        public void SetBoard(Board _board)
        {
            board = _board;
        }

        public void SetPlayers(Player _player1, Player _player2)
        {
            player1 = _player1;
            player2 = _player2;
        }

        public void Menu()
        {
            _console.DisplayText("Welcome to TicTacToe!");
            _console.DisplayText("Game Options:");
            _console.DisplayText("1. Human v. Human");
            UserInput();
        }

        public void UserInput()
        {
            _console.DisplayText("Select your option: ");
            string input = _console.GetInput();
            switch (input)
            {
                case "1":
                    Play();
                    break;
                default:
                    _console.DisplayText("Invalid Option. Try again.");
                    UserInput();
                    break;
            }
        }

        public void Play()
        {
            _console.DisplayBoard(board);
            do
            {
                GetCurrentPlayer();
                int position = currentPlayer.GetMove();
                if (moves.ValidMove(board, position))
                {
                    board.UpdateBoard(position, currentPlayer);
                    _console.DisplayBoard(board);
                }
                //else
                //{
                //    _console.DisplayText("This position is invalid. Try again.");
                //}
            } while (rules.Over(board) != true);

            _console.DisplayBoard(board);

            //if (rules.Won(board))
            //{
            //    _console.DisplayText($"Game Over. {currentPlayer._marker} is the winner.");
            //}
            //else
            //{
            //    _console.DisplayText("Game is Draw!");
            //}
        }

        public Player GetCurrentPlayer()
        {
            currentPlayer = moves.TurnCount(board.cells) % 2 == 0 ? player1 : player2;
            return currentPlayer;
        }
    }
}