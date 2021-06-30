using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHRMApplication.OrangeHRMPages
{
    class ForgotPasswordPage 
    {
        private static By oranheHrmusername = By.Id("securityAuthentication_userName");
        public static void EnterOrangeHRMUsername(IWebDriver driver,String username)
        {
            driver.FindElement(oranheHrmusername).SendKeys(username);
        }
    }
}
