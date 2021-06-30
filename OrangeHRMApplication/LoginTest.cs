using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;
using Maveric.OrangeHrmApplication.OrangeHrmPages;


namespace Maveric.OrangeHRMApplication
{
    class LoginTest
    {
        IWebDriver driver;
        //Browser start activity
        [SetUp]
        public void OrangeSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com";
        }
        //Browser End activity
        [TearDown]
        public void OrangeTearDown()
        {
            driver.Quit();
        }

        [Test]
        public void ValidCredntialTest()
        {

            LoginPage.EnterUsername(driver, "Admin");
            LoginPage.EnterPassword(driver, "admin123");
            LoginPage.ClickOnLogin(driver);
            string actualValue = DashboardMenuPage.GetEmployeeDistributionByUnitHeader(driver);
            Assert.AreEqual("Employee Distribution by Subunit", actualValue);
        }
        [Test]
        public void InvalidCredentialTest()
        {

            LoginPage.EnterUsername(driver, "Admin123");
            LoginPage.EnterPassword(driver, "admin123");
            LoginPage.ClickOnLogin(driver);
            string actualValue = LoginPage.GetErrorMessage(driver);
            Assert.AreEqual("Invalid credentials", actualValue);
        }
        [Test]
        public void ForgotPasswordTest()
        {
            LoginPage.ClickOnForgotPassword(driver);
             
        }

    }
}

























