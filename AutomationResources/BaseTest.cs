using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationResources
{
    public class BaseTest
    {
        private IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupForEveryTestMethod()
        {
            var factory = new WebDriverFactory();
            Driver = factory.Create(BrowserType.Chrome);
        }
        [TestCleanup]
        public void CleanUpAfterEveryTestMethod()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}