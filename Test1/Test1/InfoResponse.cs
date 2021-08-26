using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Test1
{
   public static class InfoResponse
    {
        public static string Name => GetTestDataFromFile().GetValue<string>(".name");

        public static string Value => GetTestDataFromFile().GetValue<string>(".value");

        private static ISettingsFile GetTestDataFromFile()
        {
            return new JsonSettingsFile("TestData.Data.json", Assembly.GetCallingAssembly());
        }
    }
}
