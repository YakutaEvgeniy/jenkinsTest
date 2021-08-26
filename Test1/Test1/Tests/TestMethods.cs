using NUnit.Framework;
using Test1.Models;
using NUnit.Framework;

using Aquality.Selenium.Browsers;

namespace Test1.Tests
{
    [TestFixture]
    class TestMethods
    {
        [SetUp]
        public void SetUp()
        {
            AqualityServices.Browser.GoTo(InfoResponse.Url);
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("https://vk.com/", InfoResponse.Url, "is not equal");

            Assert.AreEqual("https://api.vk.com/method", InfoResponse.ApiUrl, "Name is wrong");

            Assert.AreEqual("PuV6j_.2&$m9h?UYY", User.Password, "password is wrong");

            Assert.AreEqual("+375291660762", User.Login, "login is wrong");
        }
    }
}
