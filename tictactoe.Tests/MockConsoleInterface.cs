using System;
namespace tictactoe.Tests
{
    public class MockConsoleInterface : IUserInterface
    {
        public int NumTimesCallisCalled = 0;
        public int NumTimesGetInputisCalled = 0;

        public void Call(string text)
        {
            NumTimesCallisCalled++;
        }

        public string GetInput()
        {
            NumTimesGetInputisCalled++;
            return "7";
        }
    }
}
