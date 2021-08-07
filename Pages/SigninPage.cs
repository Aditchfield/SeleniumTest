using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject.Pages
{
    public class SigninPage
    {

        private By phoneNo = By.Id("phoneNo");
        private By password = By.Id("password");
        private By login = By.Id("checkLogin");

        public void SignIn(IWebDriver driver)
        {
            driver.FindElement(phoneNo).SendKeys("07368696269");
            driver.FindElement(password).SendKeys("@abc123");
            driver.FindElement(login).Click();
        }
    }
}
