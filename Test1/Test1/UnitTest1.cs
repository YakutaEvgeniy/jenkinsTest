using NUnit.Framework;
using System;

namespace Test1
{
    public class Tests
    {
        string value="123";

        [SetUp]
        public void Setup()
        {
            value = Environment.GetEnvironmentVariable("Name");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("hello", value, "is not equal");
        }
    }
}