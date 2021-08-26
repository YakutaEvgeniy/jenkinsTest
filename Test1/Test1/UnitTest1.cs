using NUnit.Framework;
using System;

namespace Test1
{
    public class Tests
    {
        string name = InfoResponse.Name;

        string value = InfoResponse.Value;

        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", value, "is not equal");

            Assert.AreEqual("Tom", name, "Name is wrong");
        }
    }
}