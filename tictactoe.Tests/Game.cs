using System;
using System.IO;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
    public class GameTest
    {
       [Fact]
       public void MenuTest()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Game game = new Game();
            var expected = "Welcome to TicTacToe!Game Options:1. Human v. Human";

            game.Menu();

            var actual = stringWriter.ToString().Replace(Environment.NewLine, "");

            Assert.Equal(expected, actual);
        }
    }
}
