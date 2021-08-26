using NUnit.Framework;
using System;

namespace Test1
{
    public class Tests
    {
        string value="123";

        string name = "Bill";

        [SetUp]
        public void Setup()
        {
            value = InfoResponse.Value;
            name = InfoResponse.Name;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", value, "is not equal");

            Assert.AreEqual("Tom", name, "Name is wrong");
        }
    }
}