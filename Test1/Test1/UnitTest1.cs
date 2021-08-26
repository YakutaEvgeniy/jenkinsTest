using NUnit.Framework;

namespace Test1
{
    public class Tests
    { 

        [SetUp]
        public void Setup()
        {  
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", InfoResponse.Value, "is not equal");

            Assert.AreEqual("Tom", InfoResponse.Name, "Name is wrong");
        }
    }
}