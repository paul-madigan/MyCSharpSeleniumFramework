using OpenQA.Selenium;

namespace MyFramework
{
    internal class BaseSampleApplicationPage
    {
        protected IWebDriver Driver { get; set; }

        public BaseSampleApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}