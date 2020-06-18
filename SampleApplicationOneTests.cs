using System;
using System.IO;
using System.Reflection;
using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyFramework
{
    [TestClass]
    [TestCategory("SampleApplicationOne")]
    public class SampleApplicationOneTests
    {
        private IWebDriver Driver { get; set; }
        internal SampleApplicationPage SampleAppPage { get; private set; }
        internal TestUser TheTestUser { get; private set; }

        [TestMethod]
        [Description("Validate user is able to fill out form with valid data")]
        [TestProperty("Author", "Paul Madigan")]
        public void TestOne()
        {
            SampleAppPage.GoTo();

            var UltimateQAHomePage = SampleAppPage.FilloutFormandSubmit(TheTestUser);
            Assert.IsTrue(UltimateQAHomePage.IsVisible, "UltimateQA home page was not visible");

        }
        [TestMethod]
        public void TestTwo()
        {
            SampleAppPage.GoTo();

            var UltimateQAHomePage = SampleAppPage.FilloutFormandSubmit(TheTestUser);
            Assert.IsTrue(UltimateQAHomePage.IsVisible, "UltimateQA home page was not visible");
        }


        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

    }
}
