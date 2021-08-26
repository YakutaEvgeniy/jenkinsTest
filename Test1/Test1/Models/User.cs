using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Test1.Models
{
    public static class User
    {
        public static int Password => GetTestDataFromFile().GetValue<int>(".password");

        public static string Login => GetTestDataFromFile().GetValue<string>(".login");

        private static ISettingsFile GetTestDataFromFile()
        {
            return new JsonSettingsFile("TestData.UserData.json", Assembly.GetCallingAssembly());
        }
    }
}
