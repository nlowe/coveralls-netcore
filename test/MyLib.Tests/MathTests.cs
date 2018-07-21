using System;
using Xunit;

namespace MyLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddValid()
        {
            var result = MyLib.Math.Add(1, 2);

            Assert.Equal(3, result);
        }
    }
}
