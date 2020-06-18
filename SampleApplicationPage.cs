using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace MyFramework
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        public SampleApplicationPage(IWebDriver driver) : base(driver) { }

        public bool isLoaded {
            get
            {
                return Driver.Title.Contains(PageTitle);
            }
            internal set
            {

            }
        }

        private string PageTitle => "Sample Application Lifecycle - Sprint 2 - Ultimate QA";
        public IWebElement firstNameField => Driver.FindElement(By.XPath("//input[@name='firstname']"));
        public IWebElement submitButton => Driver.FindElement(By.XPath("//input[@type='submit']"));
        public IWebElement lastNameField => Driver.FindElement(By.XPath("//input[@name='lastname']"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-2/");
            Assert.IsTrue(isLoaded,
                $"Sample Application was not visible. Expected=>{PageTitle}." +
                $"Actual=>{Driver.Title}");
        }

        internal UltimateQAHomePage FilloutFormandSubmit(TestUser user)
        {
            firstNameField.SendKeys(user.FirstName);
            lastNameField.SendKeys(user.LastName);
            submitButton.Submit();
            return new UltimateQAHomePage(Driver);
        }
    }
}