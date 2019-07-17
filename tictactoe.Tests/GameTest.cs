using System;
using Xunit;
using System.Collections.Generic;
using Xunit.Abstractions;

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
        public void GameMenuDisplaysHumanvHumanOption()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Contains("1. Human v. Human", console.CaptureOutput);
        }

        [Fact]
        public void GameMenuDisplaysHumanvAiOption()
        {
            console.setUserInputs(new List<string> { "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Contains("2. Human v. Ai", console.CaptureOutput);
        }

        [Fact]
        public void GamePlaysThroughTheWholeGameTest()
        {

            console.setUserInputs(new List<string> { "1", "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();
            Board gameBoard = game.GetBoard();

            Assert.Equal(2, Array.FindAll(gameBoard.cells, element => element == " ").Length);
        }

        [Fact]
        public void GameCallsConsoleDisplayBoardTest()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(console.NumTimesDisplayBoardIsCalled > 7);
        }

        [Fact]
        public void GameMenuDisplaysHindiLanguageOptions()
        {
            console.setUserInputs(new List<string> { "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Contains("1. English 2. हिंदी", console.CaptureOutput);
        }

        [Fact]
        public void GameGetsInputFromPlayerToSelectMarker()
        {
            console.setUserInputs(new List<string> { "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(console.NumTimesGetInputIsCalled > 7);
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
            console.setUserInputs(new List<string> { "1", "1", "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

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
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.SetBoard(board);
            game.Menu();

            Assert.Equal("O", board.cells[3]);
        }

        [Fact]
        public void GamePlayChecksForDraw()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(rules.DrawIsCalled);
        }

        [Fact]
        public void GamePlayChecksForWon()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.True(rules.WonIsCalled);
        }

        [Fact]
        public void GamePlayDisplaysDrawInEnglish()
        {
            console.setUserInputs(new List<string> { "1", "1", "1", "2", "3", "5", "6", "9", "8", "7", "4" });

            game.Menu();

            board = game.GetBoard();

            Assert.Contains("Game is Draw!", console.CaptureOutput);
        }

        [Fact]
        public void GamePlayDisplaysDrawInHindi()
        {
            console.setUserInputs(new List<string> { "2", "1", "1", "2", "3", "5", "6", "9", "8", "7", "4" });

            game.Menu();

            board = game.GetBoard();

            Assert.Contains("खेल ड्रा है!", console.CaptureOutput);
        }

        [Fact]
        public void GamePlayDisplaysWinInEnglish()
        {
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Contains("O is the winner", console.CaptureOutput);
        }

        [Fact]
        public void GamePlayDisplaysWinInHindi()
        {
            console.setUserInputs(new List<string> { "2", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game.Menu();

            Assert.Contains("विजेता है", console.CaptureOutput);
        }
    }
}
