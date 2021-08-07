using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTestProject.Pages;

namespace SeleniumTestProject
{
    [TestClass]
    public class Tests
    {
        IWebDriver driver;
        Homepage homepage;

        [TestInitialize]
        public void Startup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://cust.themodernmilkman.co.uk/");
            homepage = new Homepage();
        }
        [TestMethod]
        public void SignUpTest()
        {
            var signupPage = homepage.EnterPostcode(driver);
            signupPage.SubmitForm(driver);
        }
        [TestMethod]
        public void SignInTest() 
        {
            var signinPage = homepage.ClickSignIn(driver);
            signinPage.SignIn(driver);
        }
        [TestMethod]
        public void GetStartedTest()
        {
            var getStartedPage = homepage.ClickGetStarted(driver);
            getStartedPage.FillAndSubmitForm(driver);
        }
        [TestCleanup]
        public void Shutdown()
        {
            driver.Close();
        }
    }
}
