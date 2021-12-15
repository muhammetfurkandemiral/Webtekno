using System;
using NUnit.Framework;

namespace Webtekno
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {

            Driver.get().Url = "https://www.webtekno.com/";
            Driver.get().Manage().Window.Maximize();
            Driver.get().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void tearDown()
        {
            Driver.get().Close();
        }

    }
}