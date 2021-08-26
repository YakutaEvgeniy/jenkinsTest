using NUnit.Framework;
using Aquality.Selenium.Browsers;
namespace Test1.Tests
{
   public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            AqualityServices.Browser.GoTo(InfoResponse.Url);
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.WaitForPageToLoad();
        }
    }
}
