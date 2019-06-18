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
            var expected = "Welcome to TicTacToe!\nGame Options:\n1. Human v. Human\n";

            game.Menu();

            var actual = stringWriter.ToString();

            Assert.Equal(expected, actual);
        }
    }
}
