using CommbankTesting.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommbankTesting.Pages
{
    public class TravelProductPage : Utilities
    {
        RemoteWebDriver _driver;
        public TravelProductPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement travelMoneySubset => _driver.FindElementByLinkText("Travel products");
        private IWebElement travelCheckList => _driver.FindElementByLinkText("Travel checklist");
        private IWebElement emergency => _driver.FindElementByLinkText("In an emergency");
        private IWebElement tools => _driver.FindElementByLinkText("Tools & support");

        public void VerifyTravelMoneySubset()
        {
            VerifyElement(travelMoneySubset);
        }
        public void VerifySubLinks()
        {
            VerifyElement(travelCheckList);
            VerifyElement(emergency);
            VerifyElement(tools);
        }
    }
}