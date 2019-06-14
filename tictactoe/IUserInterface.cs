using System;
namespace tictactoe
{
    public interface IUserInterface
    {
        void Call(string text);
        string GetInput();
    }
}
