using System;

namespace tictactoe.Tests
{
    public class MockConsoleInterface : IUserInterface
    {
        public int NumTimesDisplayTextisCalled = 0;
        public int NumTimesGetInputisCalled = 0;

        public void DisplayText(string text)
        {
            NumTimesDisplayTextisCalled++;
        }

        public string GetInput()
        {
            NumTimesGetInputisCalled++;
            return "1";
        }

        public void DisplayBoard(Board board)
        {
            NumTimesDisplayTextisCalled++;
        }
    }
}