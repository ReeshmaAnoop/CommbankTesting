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
        private IWebElement TravelMoneySubset => _driver.FindElementByLinkText("Travel products");
        private IWebElement TravelCheckList => _driver.FindElementByLinkText("Travel checklist");
        private IWebElement Emergency => _driver.FindElementByLinkText("In an emergency");
        private IWebElement Tools => _driver.FindElementByLinkText("Tools & support");
        
        public void VerifyTravelMoneySubset()
        {
            VerifyElement(TravelMoneySubset);
        }
        public void VerifySubLinks()
        {
            VerifyElement(TravelCheckList);
            VerifyElement(Emergency);
            VerifyElement(Tools);
        }
    }
}