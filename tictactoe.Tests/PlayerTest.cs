using System;
using Xunit;

namespace tictactoe.Tests
{
    public class PlayerTest
    {
        private MockConsoleInterface console;
        private Player player;

        public PlayerTest()
        {
            console = new MockConsoleInterface();
            player = new Player("X", console);
        }

        [Fact]
        public void MoveReturnsPosition()
        {
            Assert.Equal(1, player.Move());
        }
    }
}