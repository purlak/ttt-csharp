using System;
using System.IO;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
    public class GameTest
    {
        private MockConsoleInterface console;
        private Board board;
        private Game game;

        public GameTest()
        {
            console = new MockConsoleInterface();
            board = new Board(console);
            game = new Game(console);
        }

        [Fact]
        public void MenuTest()
        {
            game.Menu();

            Assert.True(console.NumTimesDisplayTextisCalled > 0);
        }

        [Fact]
        public void UserInputTest()
        {
            game.UserInput();

            Assert.True(console.NumTimesGetInputisCalled > 0);
        }

        [Fact]
        public void PlayCallsConsoleDisplayBoard()
        {
            game.Play();

            Assert.True(console.NumTimesDisplayTextisCalled > 0);
        }
    }
}
