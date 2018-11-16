using System;
using Domain; // use namespace to reference!
using Xunit;

namespace typoonSkriptTTD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Deck deck = new Deck();
            Assert.Equals(52);
        }
    }
}
