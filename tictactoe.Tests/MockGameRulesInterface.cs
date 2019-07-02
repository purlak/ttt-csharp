using System;
namespace tictactoe.Tests
{
    public class MockGameRulesInterface : IGameRulesInterface
    {
        public bool DrawIsCalled;
        public bool WonIsCalled;

        public bool Draw(Board board) => DrawIsCalled = true;

        public bool Over(Board board) => new GameRules().Over(board);

        public bool Won(Board board) => WonIsCalled = true;
    }
}
