using System;
using Xunit;

namespace tictactoe.Tests
{
    public class MovesTest
    {
        private Moves moves;
        private Board board;

        public MovesTest()
        {
            moves = new Moves();
            board = new Board();
        }

        [Fact]
        public void FullReturnsFalseWhenBoardIsEmpty()
        {
            string[] cells = {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "};

            Assert.False(moves.Full(cells));
        }

        [Fact]
        public void FullReturnsFalseWhenBoardIsNotFull()
        {
            string[] cells = {
                "X", " ", " ",
                " ", "O", " ",
                " ", "X", "O"};

            Assert.False(moves.Full(cells));
        }

        [Fact]
        public void FullReturnsTrueWhenBoardFull()
        {
            string[] cells = {
                "X", "O", "O",
                "O", "X", "X",
                "X", "X", "O"};

            Assert.True(moves.Full(cells));
        }

        [Fact]
        public void TakenReturnsTrueWhenCellHasAMarker()
        {
            int input = 5;

            board.cells = new string[] {
                "X", "O", "O",
                "O", "X", " ",
                " ", "X", " "};

            Assert.True(moves.Taken(board, input));
        }

        [Fact]
        public void TakenReturnsFalseWhenCellIsEmpty()
        {
            int input = 5;

            board.cells = new string[] {
                "X", "O", " ",
                "O", " ", " ",
                " ", "X", " "};

            Assert.False(moves.Taken(board, input));
        }

        [Fact]
        public void ValidMoveReturnsTrueWhenInputBetweenOneAndNine()
        {
            int input = 1;

            board.cells = new string[] {
                " ", "O", " ",
                "O", " ", " ",
                " ", "X", " "};

            Assert.True(moves.ValidMove(board, input));
        }

    }
}