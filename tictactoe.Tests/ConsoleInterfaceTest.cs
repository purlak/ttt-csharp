using System;
using System.IO;
using Xunit;

namespace tictactoe.Tests
{
    public class ConsoleInterfaceTest
    {
        public ConsoleInterface console;

        public ConsoleInterfaceTest()
        {
            console = new ConsoleInterface();
        }

        [Fact]
        public void DisplayTextTest()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var text = "Hello";

            console.DisplayText(text);

            var actual = stringWriter.ToString().Replace(Environment.NewLine, "");

            Assert.Equal(text, actual);
        }

        [Fact]
        public void GetInputTest()
        {
            string input = "Hello";
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var actual = console.GetInput();

            Assert.Equal(input, actual);
        }
    }
}