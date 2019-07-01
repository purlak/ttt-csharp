using System;
namespace tictactoe.Tests
{
    public class MockGameRulesInterface : IGameRulesInterface
    {
        public bool DrawIsCalled;
        public bool WonIsCalled;
        public bool GameIsOver;

        public bool Draw(Board board) => DrawIsCalled = true;

        public bool Over(Board board)
        {
            GameRules rules = new GameRules();
            if (rules.Over(board))
            {
                GameIsOver = true;
                return GameIsOver;
            }
            GameIsOver = false;
            return GameIsOver;
        }

        public bool Won(Board board) => WonIsCalled = true;
    }
}
