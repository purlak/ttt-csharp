﻿using Xunit;

namespace tictactoe.Tests
{
    public class PlayerTest
    {
        private MockConsoleInterface console;
        private Player player;
        private Board board;

        public PlayerTest()
        {
            console = new MockConsoleInterface();
            player = new Player("X", console);
        }

        [Fact]
        public void GetMoveReturnsPosition()
        {
            Assert.Equal(1, player.GetMove(board));
        }
    }
}