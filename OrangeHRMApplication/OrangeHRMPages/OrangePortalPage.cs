using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHrmApplication.OrangeHrmPages
{
    class OrangePortalPage
    {
        private static By profileIconLocator = By.Id("welcome");
        private static By aboutLocator = By.LinkText("About");
        private static By companyDetailLocator = By.Id("companyInfo");
        private static By myInfoLocator = By.Id("menu_pim_viewMyDetails");
        private static By dashboardLocator= By.Id("menu_dashboard_index");
        private static By directoryLocator = By.Id("menu_directory_viewDirectory");
        public static void ClickOnMyInfoMenu(IWebDriver driver)
        {
            driver.FindElement(myInfoLocator).Click();
        }
        public static void ClickOnDashboardMenu(IWebDriver driver)
        {
            driver.FindElement(dashboardLocator).Click();
        }

        public static void ClickOnDirectoryMenu(IWebDriver driver)
        {
            driver.FindElement(directoryLocator).Click();
        }
        public static void ClickOnProfileIcon(IWebDriver driver)
        {
            driver.FindElement(profileIconLocator).Click();
        }
        public static void ClickOnAbout(IWebDriver driver)
        {
            driver.FindElement(aboutLocator).Click();
        }

        public static String GetAboutSectionDetail(IWebDriver driver)
        {
            return driver.FindElement(companyDetailLocator).Text;
        }
    }
}