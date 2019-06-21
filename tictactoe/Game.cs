using System;

namespace tictactoe
{
    public class Game
    {
        private IUserInterface _console;
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private GameRules rules;
        private Moves moves;

        public Game(IUserInterface console)
        {
            _console = console;
            board = new Board(_console);
            rules = new GameRules();
            moves = new Moves();
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
                Turn();
            } while (rules.Over(board) != true);

            if (rules.Draw(board))
            {
                _console.DisplayText("Game Draws.");
            }
            else if (rules.Won(board))
            {
                _console.DisplayText($"Game Over.Winner is {currentPlayer._marker}.");
            }
        }

        public void Turn()
        {
            CurrentPlayer();
            _console.DisplayText($"It's now {currentPlayer._marker}'s turn.");
            int input = currentPlayer.GetMove()                                                                                                                                                                                                                                               ;
            if (moves.ValidMove(board, input))
            {
                board.UpdateBoard(input, currentPlayer);
                _console.DisplayBoard(board);
            }
            else if (moves.Between(input) == false)
            {
                _console.DisplayText("Invalid Move. Try again.");
                CurrentPlayer();
                Turn();
            }

            else if (moves.Taken(board, input))
            {
                _console.DisplayText("This position is already taken. Try again.");
                CurrentPlayer();
                Turn();

            }
        }

        private void GetPlayers()
        {
            player1 = new Player("X", _console);
            player2 = new Player("O", _console);
        }

        public Player CurrentPlayer()
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