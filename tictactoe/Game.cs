using System;

namespace tictactoe
{
    public class Game
    {
        private IUserInterface _console;
        private Board board;

        public Game(IUserInterface console)
        {
            _console = console;
            board = new Board(console);
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
        }
    }
}