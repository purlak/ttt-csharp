using Xunit;

namespace tictactoe.Tests
{
    public class GameRulesTest
    {
        private Board board;
        private GameRules rules;

        public GameRulesTest ()
        {
            board = new Board();
            rules = new GameRules();
        }

        [Fact]
        public void DrawReturnsFalseForEmptyBoard()
        {
            board.cells = new string[] {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "};

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
