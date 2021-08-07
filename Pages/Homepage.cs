using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestProject.Pages
{
    public class Homepage
    {
        private By menu = By.ClassName("navbar-toggler");
        private By signInBtn = By.ClassName("signinmobile");
        private By postcode = By.Id("postcode");
        private By findBtn = By.Id("checkPostcode5");
        private By getStartedBtn = By.ClassName("btn-gets");

        public SignupPage EnterPostcode(IWebDriver driver)
        {
            driver.FindElement(postcode).SendKeys("LS20 8JN");
            driver.FindElement(findBtn).Click();
            return new SignupPage();
        }

        public SigninPage ClickSignIn(IWebDriver driver)
        {
            driver.FindElement(menu).Click();
            driver.FindElement(signInBtn).Click();
            return new SigninPage();
        }

        public GetStartedPage ClickGetStarted(IWebDriver driver)
        {
            driver.FindElement(getStartedBtn).Click();
            return new GetStartedPage();
        }
    }
}
