using System;
using Xunit;
using System.Collections.Generic;

namespace tictactoe.Tests
{
    public class GameTest
    {
        private MockConsoleInterface console;
        private MockGameRulesInterface rules;
        private Game game;
        private Board board;
        private Player player1;
        private Player player2;

        public GameTest()
        {
            console = new MockConsoleInterface();
            rules = new MockGameRulesInterface();
            board = new Board();
            player1 = new Player("X", console);
            player2 = new Player("O", console);
            game = new Game(console, rules, player1, player2);
        }

        [Fact]
        public void GamePlaysThroughTheWholeGameTest()
        {

            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();
            Board gameBoard = game.GetBoard();

            Assert.Equal(2, Array.FindAll(gameBoard.cells, element => element == " ").Length);
        }

        [Fact]
        public void GameCallsConsoleDisplayBoardTest()
        {
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(console.NumTimesDisplayBoardIsCalled > 7);
        }

        [Fact]
        public void GameGetsInputFromPlayerToSelectMarker()
        {
            console.setUserInputs(new List<string> { "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(console.NumTimesGetInputIsCalled > 8);
        }

        [Fact]
        public void GameAllowsPlayer1ToHaveMarkerXAndPlayer2ToHaveMarkerO()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Equal("X", game.GetPlayer1()._marker);
            Assert.Equal("O", game.GetPlayer2()._marker);
        }

        [Fact]
        public void GameAllowsPlayer1ToHaveMarkerOAndPlayer2ToHaveMarkerX()
        {
            console.setUserInputs(new List<string> { "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Equal("O", game.GetPlayer1()._marker);
            Assert.Equal("X", game.GetPlayer2()._marker);
        }

        [Fact]
        public void GetCurrentPlayerReturnsPlayer2Test()
        {
            board.cells = new string[] {
                    "X", " ", " ",
                    " ", " ", " ",
                    " ", " ", " "};
            game.SetBoard(board);

            Player currentPlayer = game.GetCurrentPlayer();

            Assert.Equal("O", currentPlayer._marker);
        }

        [Fact]
        public void GetCurrentPlayerReturnsPlayer1Test()
        {
            board.cells = new string[] {
                    "X", "O", " ",
                    " ", " ", " ",
                    " ", " ", " "};

            game.SetBoard(board);

            Player currentPlayer = game.GetCurrentPlayer();

            Assert.Equal("X", currentPlayer._marker);
        }

        [Fact]
        public void GamePlayChecksForValidMoveAndDoesNotReplaceTakenCell()
        {
            board.cells = new string[] {
                    "X", "O", " ",
                    " ", " ", " ",
                    " ", " ", " "};
            console.setUserInputs(new List<string> { "1", "1", "2", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.Equal("O", board.cells[1]);
        }

        [Fact]
        public void GamePlayChecksForValidMoveAndAllowsPlayerToPlaceAMarkOnAnEmptyCell()
        {
            board.cells = new string[] {
                    "X", "O", "X",
                    " ", " ", " ",
                    " ", " ", " "};
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.Equal("O", board.cells[3]);
        }

        [Fact]
        public void GamePlayChecksForDraw()
        {
            board.cells = new string[] {
                    "X", "O", "X",
                    "X", "O", "O",
                    "O", "X", "X"};
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.True(rules.DrawIsCalled);
        }

        [Fact]
        public void GamePlayChecksForWon()
        {
            board.cells = new string[] {
                    "X", "O", "X",
                    "O", "X", "O",
                    "X", "O", "X"};
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.True(rules.WonIsCalled);
        }

        [Fact]
        public void GamePlayDisplaysDraw()
        {
            board.cells = new string[] {
                    "X", "O", "X",
                    "X", "O", "O",
                    "O", "X", "X"};
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.Contains("Game is Draw!", console.CaptureOutput);
        }

        [Fact]
        public void GamePlayDisplaysWin()
        {
            board.cells = new string[] {
                    "X", "O", "X",
                    "O", "X", "O",
                    "X", "O", "X"};
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.Contains("O is the winner", console.CaptureOutput);
        }
    }
}
