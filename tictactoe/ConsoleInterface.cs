using System;

namespace tictactoe
{
    public class ConsoleInterface : IUserInterface
    {
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}