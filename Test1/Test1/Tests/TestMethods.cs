using NUnit.Framework;
using Test1.Models;
using NUnit.Framework;

using Aquality.Selenium.Browsers;

namespace Test1.Tests
{
    
    class TestMethods
    {         
        [Test]
        public void Test1()
        {
            var url = InfoResponse.Url;
            AqualityServices.Browser.GoTo(url);
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.WaitForPageToLoad();

            Assert.AreEqual("https://vk.com/", InfoResponse.Url, "is not equal");

            Assert.AreEqual("https://api.vk.com/method", InfoResponse.ApiUrl, "Name is wrong");

            Assert.AreEqual("PuV6j_.2&$m9h?UYY", User.Password, "password is wrong");

            Assert.AreEqual("+375291660762", User.Login, "login is wrong");
            AqualityServices.Browser.Quit();
        }
    }
}
