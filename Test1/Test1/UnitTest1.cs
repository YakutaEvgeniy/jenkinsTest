using NUnit.Framework;
using System;

namespace Test1
{
    public class Tests
    {
        string value = Environment.GetEnvironmentVariable("Name");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(value, "hello", "is not equal");
        }
    }
}