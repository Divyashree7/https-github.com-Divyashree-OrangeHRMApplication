using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHrmApplication.OrangeHrmPages
{
    class LoginPage
    {
        private static By usernameLocator = By.Id("txtUsername");
        private static By passwordLocator = By.Id("txtPassword");
        private static By loginLoctor = By.XPath("//*[@id='btnLogin']");
        private static By errorLocator = By.Id("spanMessage");
        private static By forgotPassword = By.LinkText("Forgot your password?");

        public static void EnterUsername(IWebDriver driver, string username)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
        }

        public static void EnterPassword(IWebDriver driver, string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }
        public static void ClickOnLogin(IWebDriver driver)
        {
            driver.FindElement(loginLoctor).Click();
        }
        //geterrormessage
        public static string GetErrorMessage(IWebDriver driver)
        {
            return driver.FindElement(errorLocator).Text;
        }
        //clickonforgotpassword
        public static void ClickOnForgotPassword(IWebDriver driver)
        {
            driver.FindElement(forgotPassword).Click();
        }




    }
}