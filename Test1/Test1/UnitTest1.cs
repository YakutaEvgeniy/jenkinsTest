using NUnit.Framework;
using Test1.Models;

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
            Assert.AreEqual("https://vk.com/", InfoResponse.Url, "is not equal");

            Assert.AreEqual("https://api.vk.com/method", InfoResponse.ApiUrl, "Name is wrong");

            Assert.AreEqual(627657327, User.UserId, "id is wrong");

            Assert.AreEqual("+375291660762", User.Login, "login is wrong");
        }
    }
}