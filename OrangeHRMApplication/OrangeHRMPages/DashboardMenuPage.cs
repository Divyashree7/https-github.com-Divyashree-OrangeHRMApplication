﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maveric.OrangeHrmApplication.OrangeHrmPages
{
    class DashboardMenuPage
    {
        private static By employeeDistributionHeaderLocator = By.XPath("//legend[contains(text(),'Distribution')]");
        public static string GetEmployeeDistributionByUnitHeader(IWebDriver driver)
        {
            return driver.FindElement(employeeDistributionHeaderLocator).Text;
        }

        public static void ClickOnAssignLeave()
        {

        }
    }
}