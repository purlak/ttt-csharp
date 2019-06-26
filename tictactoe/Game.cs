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
        }

        public Board GetBoard()
        {
            return board;
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
            GetPlayers();
            do
            {
                GetCurrentPlayer();
                board.UpdateBoard(currentPlayer.GetMove(), currentPlayer);
            } while (rules.Over(board) != true);

            _console.DisplayBoard(board);
        }

        public void Turn()
        {
            GetCurrentPlayer();
            _console.DisplayText($"It's now {currentPlayer._marker}'s turn.");
            int input = currentPlayer.GetMove();
            if (moves.ValidMove(board, input))
            {
                board.UpdateBoard(input, currentPlayer);
                _console.DisplayBoard(board);
            }
            else if (moves.Between(input) == false)
            {
                _console.DisplayText("Invalid Move. Try again");
                Turn();
            }

            else if (moves.Taken(board, input))
            {
                _console.DisplayText("Position take. Try again.");
                GetCurrentPlayer();
                Turn();
            }
        }

        public void GetPlayers()
        {
            player1 = new Player("X", _console);
            player2 = new Player("O", _console);
        }

        public Player GetCurrentPlayer()
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