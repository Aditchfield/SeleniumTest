using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject.Pages
{
    public class GetStartedPage
    {
        private By phoneNo = By.Id("phoneNo");
        private By postcode = By.Id("postcode");
        private By getStartedBtn = By.Id("submitPostcode");

        public void FillAndSubmitForm(IWebDriver driver)
        {
            driver.FindElement(phoneNo).SendKeys("07368696269");
            driver.FindElement(postcode).SendKeys("LS20 8JN");
            driver.FindElement(getStartedBtn).Click();
        }
    }
}
