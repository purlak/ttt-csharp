using System;
using Xunit;
using tictactoe;

namespace tictactoe.Tests
{
    public class Test
    {
        [Fact]
        public void Test1()
        {
          Assert.Equal(2, 2);
        }

        [Fact]
        public void Test2()
        {
          var program = new Program();
          Assert.Equal("Hello", program.TestMethod());
        }
    }
}
