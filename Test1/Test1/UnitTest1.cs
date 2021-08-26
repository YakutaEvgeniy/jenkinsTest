using NUnit.Framework;
using System;

namespace Test1
{
    public class Tests
    {
        string Name = InfoResponse.Name;

        string Value = InfoResponse.Value;

        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Value, "is not equal");

            Assert.AreEqual("Tom", Name, "Name is wrong");
        }
    }
}