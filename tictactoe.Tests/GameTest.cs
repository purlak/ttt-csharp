using System;
using System.IO;
using Xunit;
using tictactoe;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace tictactoe.Tests
{
    public class GameTest
    {
        private MockConsoleInterface console;
        private Game game;
        private Moves moves;
        private Board board;
        private Player player1;
        private Player player2;
        private GameRules rules;

        public GameTest()
        {

            console = new MockConsoleInterface();
            game = new Game(console);
            board = new Board();
            player1 = new Player("X", console);
            player2 = new Player("O", console);
            moves = new Moves();
            rules = new GameRules();
        }

        [Fact]
        public void GamePlaysThroughTheWholeGameTest()
        {

            console = new MockConsoleInterface();
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            game = new Game(console);
            game.Menu();
            Board board = game.GetBoard();

            Assert.Equal(2, Array.FindAll(board.cells, element => element == " ").Length);
        }

        [Fact]
        public void GameCallsConsoleDisplayBoardTest()
        {

            console = new MockConsoleInterface();
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game = new Game(console);
            game.Menu();

            Assert.True(console.NumTimesDisplayBoardIsCalled > 7);
        }

        [Fact]
        public void GetCurrentPlayerReturnsPlayer2Test()    
        {
            board.cells = new string[] {
                "X", " ", " ",
                " ", " ", " ",
                " ", " ", " "};

            game.SetBoard(board);
            game.SetPlayers(player1, player2);

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
            game.SetPlayers(player1, player2);

            Player currentPlayer = game.GetCurrentPlayer();

            Assert.Equal("X", currentPlayer._marker);
        }

        [Fact]
        public void GamePlayChecksForValidMoveTest1()
        {
            board.cells = new string[] {
                "X", "O", " ",
                " ", " ", " ",
                " ", " ", " "};

            console.setUserInputs(new List<string> { "1", "1", "2", "2", "3", "4", "5", "6", "7", "8", "9" });

            game = new Game(console);

            game.SetBoard(board);
            game.SetPlayers(player1, player2);

            game.Menu();
            
            Assert.Equal("O", board.cells[1]);
        }

        [Fact]
        public void GamePlayChecksForValidMoveTest2()
        {
            board.cells = new string[] {
                "X", "O", " ",
                " ", " ", " ",
                " ", " ", " "};

            game.SetBoard(board);

            int position = 3;

            Assert.True(moves.ValidMove(board, position));
        }

        [Fact]
        public void GamePlayChecksForDraw()
        {
            board.cells = new string[] {
                "X", "O", "X",
                "X", "O", "O",
                "O", "X", "X"};

            game.SetBoard(board);

            game.Play();

            Assert.True(rules.Draw(board));
        }
    }
}
