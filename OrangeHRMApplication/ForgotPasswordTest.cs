using Maveric.OrangeHrmApplication.OrangeHrmBase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

using Maveric.OrangeHRMApplication.OrangeHRMPages;
using OpenQA.Selenium;

namespace OrangeHRMApplication
{
    class ForgotPasswordTest : WebDriverWrapper
    {
        
        [Test]
        public  void ForgotPwdTest()
        {
            ForgotPasswordPage.EnterOrangeHRMUsername(driver,"Admin");

        }
    }
}
