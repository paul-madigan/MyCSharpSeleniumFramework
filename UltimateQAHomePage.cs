using OpenQA.Selenium;

namespace MyFramework
{
    internal class UltimateQAHomePage : BaseSampleApplicationPage
    {

        public UltimateQAHomePage(IWebDriver driver) : base(driver){}

        public bool IsVisible{ 
            get
            {
                try
                {
                    return linkButton.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                    throw;
                }
            }
            set { }
        }
        public IWebElement linkButton => Driver.FindElement(By.XPath("//a[text()='Master Automation With Selenium']"));
    }
}