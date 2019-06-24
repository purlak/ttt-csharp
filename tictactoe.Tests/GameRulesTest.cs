using System;
using Xunit;
using tictactoe;
using System.Collections.Generic;
using Xunit.Abstractions;

namespace tictactoe.Tests
{
    public class GameRulesTest
    {
        private ITestOutputHelper output;
        private MockConsoleInterface console;
        private Board board;
        private GameRules rules;

        public GameRulesTest (ITestOutputHelper output)
        {
            console = new MockConsoleInterface();
            board = new Board(console);
            rules = new GameRules();
            this.output = output;
        }

        [Fact]
        public void DrawReturnsFalseForEmptyBoard()
        {
            console.setUserInputs(new List<string> { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            Assert.False(rules.Draw(board));
        }


        [Fact]
        public void DrawReturnsTrueWhenGameIsDraw()
        {
            board.cells = new string[] {
                "X", "O", "O",
                "O", "X", "X",
                "X", "X", "O"};
                    
            Assert.True(rules.Draw(board));
        }

        [Fact]
        public void OverReturnsFalseWhenBoardIsEmpty()
        {
            board.cells = new string[] {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "};

            Assert.False(rules.Over(board));
        }

        [Fact]
        public void OverReturnsFalseWhenGameIsInProgress()
        {
            board.cells = new string[] {
                " ", "O", " ",
                " ", "X", "X",
                " ", " ", " "};

            Assert.False(rules.Over(board));
        }

        [Fact]
        public void OverReturnsTrueWhenBoardIsDraw()
        {
            board.cells = new string[] {
                "X", "O", "O",
                "O", "X", "X",
                "X", "X", "O"};

            Assert.True(rules.Over(board));
        }

        [Fact]
        public void OverReturnsTrueWhenBoardIsWon()
        {
            board.cells = new string[] {
                "X", "O", "O",
                "O", "X", "X",
                "X", "O", "X"};

            Assert.True(rules.Over(board));
        }
    }
}
