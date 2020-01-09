using CommbankTesting.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommbankTesting
{
    public class CommbankLaunchPage : Utilities
    {
        RemoteWebDriver _driver;
        public CommbankLaunchPage(RemoteWebDriver driver)
        {
           _driver = driver;
        }

        private IWebElement TravelMoneyButton => _driver.FindElementByXPath("//*[@id='products']//div[1]/div[8]//a/div[2]//h3");
        public void ClickOnTravelProductLink() => Click(TravelMoneyButton);

    }
}