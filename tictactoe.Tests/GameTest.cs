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
        private ITestOutputHelper output;

        public GameTest(ITestOutputHelper output)
        {
            console = new MockConsoleInterface();
            game = new Game(console);
            this.output = output;
        }

        [Fact]
        public void GamePlaysThroughTheWholeGameTest()
        {

            console = new MockConsoleInterface();
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game = new Game(console);
            game.Menu();
            Board board = game.GetBoard();

            Assert.Equal(0, Array.FindAll(board.cells, element => element == " ").Length);
        }

        [Fact]
        public void GameCallsConsoleDisplayBoardTest()
        {

            console = new MockConsoleInterface();
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            game = new Game(console);
            game.Menu();
            
            Assert.True(console.NumTimesDisplayBoardIsCalled > 9);
        }
    }
}
