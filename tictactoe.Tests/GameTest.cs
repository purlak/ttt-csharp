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
        public void MenuTest()
        {
            game.Menu();

            Assert.True(console.NumTimesDisplayTextIsCalled > 0);
        }

        [Fact]
        public void UserInputTest()
        {
            game.UserInput();

            Assert.True(console.NumTimesGetInputIsCalled > 0);
        }

        [Fact]
        public void PlayCallsConsoleDisplayBoard()
        {
            game.Play();

            Assert.True(console.NumTimesDisplayBoardIsCalled > 0);
        }

        //[Fact]
        //public void GameLoopTest()
        //{

        //    console = new MockConsoleInterface();
        //    console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

        //    game = new Game(console);
        //    game.Menu();

        //    Board board = game.GetBoard();

        //    Assert.Equal(0, Array.FindAll(board.cells, element => element == " ").Length);
        //}
    }
}
