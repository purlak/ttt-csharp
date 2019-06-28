using System;
using System.Collections.Generic;
using System.Linq;

namespace tictactoe.Tests
{
    public class MockConsoleInterface : IUserInterface
    {
        public int NumTimesDisplayTextIsCalled = 0;
        public int NumTimesGetInputIsCalled = 0;
        public int NumTimesDisplayBoardIsCalled = 0;
        public List<string> UserInputs = new List<string>() { "1" };
       
        public void DisplayText(string text)
        {
            NumTimesDisplayTextIsCalled++;
        }

        public string GetInput()
        {
            NumTimesGetInputIsCalled++;
            if (UserInputs.Count == 0)
            {
                return "1";
            }
            else
            {
                string input = UserInputs[0];
                UserInputs.RemoveAt(0);
                return input;
            }
        }

        public void DisplayBoard(Board board)
        {
            NumTimesDisplayBoardIsCalled++;
        }

        public void setUserInputs(List<string> userInputs)
        {
            UserInputs = userInputs;
        }
    }
}