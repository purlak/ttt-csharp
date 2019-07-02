using System;

namespace tictactoe
{
    public class Game
    {
        private IUserInterface _console;
        private IGameRulesInterface _rules;
        private Board board;
        private Player _player1;
        private Player _player2;
        private Moves moves;
        private Player currentPlayer;

        public Game(IUserInterface console, IGameRulesInterface rules, Player player1, Player player2)
        {
            _console = console;
            _rules = rules;
            _player1 = player1;
            _player2 = player2;
            board = new Board();
            moves = new Moves();
        }

        public Board GetBoard()
        {
            return board;
        }

        public void SetBoard(Board _board)
        {
            board = _board;
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
                else
                {
                    _console.DisplayText("This position is invalid. Try again.");
                }
            } while (_rules.Over(board) != true);

            _console.DisplayBoard(board);

            if (_rules.Won(board))
            {
                _console.DisplayText($"Game Over. {currentPlayer._marker} is the winner.");
            }
            if (_rules.Draw(board))
            {
                _console.DisplayText("Game is Draw!");
            }
        }

        public Player GetCurrentPlayer()
        {
            currentPlayer = moves.TurnCount(board.cells) % 2 == 0 ? _player1 : _player2;
            return currentPlayer;
        }
    }
}