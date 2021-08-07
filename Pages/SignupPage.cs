using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject.Pages
{
    public class SignupPage
    {
        private By forename = By.Id("forename");
        private By surname = By.Id("surname");
        private By email = By.Id("email");
        private By phoneNo = By.Id("phoneNo");
        private By password = By.Id("password");
        private By heardFrom = By.Id("heardFrom");
        private By option = By.XPath("//*[@id='heardFrom']/option[3]");
        private By marketing = By.XPath("//*[@id='signup']/div[5]/div[1]/div/label");
        private By terms = By.XPath("//*[@id='signup']/div[5]/div[2]/div/label");
        private By formSubmit = By.ClassName(@"form-submit");

        public void SubmitForm(IWebDriver driver)
        {
            driver.FindElement(forename).SendKeys("Alan");
            driver.FindElement(surname).SendKeys("Test");
            driver.FindElement(email).SendKeys("awditchfield@gmail.com");
            driver.FindElement(phoneNo).SendKeys("07368696269");
            driver.FindElement(password).SendKeys("@abc123");
            driver.FindElement(heardFrom).Click();
            driver.FindElement(option).Click();
            driver.FindElement(marketing).Click();
            driver.FindElement(terms).Click();
            driver.FindElement(formSubmit).Click();
        }
    }
}
