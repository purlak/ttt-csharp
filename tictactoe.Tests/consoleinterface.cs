using System;
using System.IO;
using Xunit;

namespace tictactoe.Tests
{
    public class ConsoleInterfaceTest
    {
        [Fact]
        public void ItDisplaysTextToConsole()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            ConsoleInterface console = new ConsoleInterface();
            var text = "Welcome to Tic Tac Toe!";
            console.Call(text);
            var actual = stringWriter.ToString().Replace(Environment.NewLine, "");

            Assert.Equal(text, actual);
        }

        [Fact]
        public void ItReadsTextFromConsole()
        {
            string input = "Hello";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            ConsoleInterface console = new ConsoleInterface();
            var actual = console.GetInput();
            Assert.Equal(input, actual);
        }
    }
}
