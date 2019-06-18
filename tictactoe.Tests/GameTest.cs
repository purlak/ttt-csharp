using System;
using System.IO;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
    public class GameTest
    {
        public MockConsoleInterface console;
        private Board board;
        public Game game;

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
    }
}
