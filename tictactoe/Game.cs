using System;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace tictactoe
{
	public class Game
	{
		private IUserInterface _console;
		private IGameRulesInterface _rules;
		private Board _board;
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
			_board = new Board();
			moves = new Moves();
		}

		public Board GetBoard()
		{
			return _board;
		}

		public void SetBoard(Board board)
		{
			_board = board;
		}

		public Player GetPlayer1()
		{
			return _player1;
		}

		public Player GetPlayer2()
		{
			return _player2;
		}

		public void Menu()
		{
			_console.DisplayText(Resources.Welcome);
			_console.DisplayText(Resources.LanguageOption);
			_console.DisplayText(Resources.SelectOption);
			SetLanguage(_console.GetInput());
			_console.DisplayText(Resources.GameOptions);
			_console.DisplayText(Resources.GameOption1);
			_console.DisplayText(Resources.GameOption2);
			UserInput();
		}

		private void SetLanguage(string langInput)
		{
			if (langInput.Equals("1"))
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
			}
			else if (langInput.Equals("2"))
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi");
			}
		}

		public void UserInput()
		{
			_console.DisplayText(Resources.SelectOption);
			string input = _console.GetInput();
			switch (input)
			{
				case "1":
					SelectMarker();
					Play();
					break;
				case "2":
					_player2 = new AiPlayer("O", _console);
					SelectMarker();
					Play();
					break;
				default:
					_console.DisplayText(Resources.InvalidOption);
					UserInput();
					break;
			}
		}

		public void SelectMarker()
		{
			_console.DisplayText(Resources.SelectMarker);
			string input = _console.GetInput();
			switch (input)
			{
				case "1":
					break;
				case "2":
					_player1._marker = "O";
					_player2._marker = "X";
					break;
				default:
					_console.DisplayText(Resources.InvalidOption);
					SelectMarker();
					break;
			}
		}

		public void Play()
		{
			_console.DisplayBoard(_board);
			do
			{
				GetCurrentPlayer();
				int position = currentPlayer.GetMove(_board);
				if (moves.ValidMove(_board, position))
				{
					_board.UpdateBoard(position, currentPlayer);
					_console.DisplayBoard(_board);
				}
				else
				{
					_console.DisplayText(Resources.InvalidPosition);
				}
			} while (_rules.Over(_board) != true);

			_console.DisplayBoard(_board);

			if (_rules.Won(_board))
			{
				_console.DisplayText(Resources.GameOver + $"{currentPlayer._marker}" + Resources.IsWinner);
			}

			if (_rules.Draw(_board))
			{
				_console.DisplayText(Resources.GameDraw);
			}
		}

		public Player GetCurrentPlayer()
		{
			currentPlayer = moves.TurnCount(_board.cells) % 2 == 0 ? _player1 : _player2;
			return currentPlayer;
		}
	}
}