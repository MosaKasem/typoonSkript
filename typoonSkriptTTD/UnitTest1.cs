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
            MaxAge maxAge = new MaxAge(17);
            CheckAge checkAge = new CheckAge();
            var actual = checkAge.AgeChecker(17);
            var exception = new Exception();
            Assert.Throws(new Exception(exception));
        }
    }
}
