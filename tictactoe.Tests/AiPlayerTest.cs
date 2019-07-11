using System.Collections.Generic;
using Xunit;

namespace tictactoe.Tests
{
    public class AiPlayerTest
    {
        private Board board;
        private MockConsoleInterface console;
        private AiPlayer aiPlayer;

        public AiPlayerTest()
        {
            console = new MockConsoleInterface();
            board = new Board();
            aiPlayer = new AiPlayer("O", console);
        }

        [Fact]
        public void AiPlayerReturnsRandomNumberBetween1And9()
        {
            List<int> randomNumberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int aiInput = aiPlayer.GetMove(board);
            Assert.Contains(aiInput, randomNumberList);
        }
    }
}
