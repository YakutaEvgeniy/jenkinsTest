﻿using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Test1
{
   public static class InfoResponse
    {
        public static string Url => GetTestDataFromFile().GetValue<string>(".auth_url");

        public static string ApiUrl => GetTestDataFromFile().GetValue<string>(".vk_api");

        private static ISettingsFile GetTestDataFromFile()
        {
            return new JsonSettingsFile("TestData.UrlData.json", Assembly.GetCallingAssembly());
        }
    }
}
