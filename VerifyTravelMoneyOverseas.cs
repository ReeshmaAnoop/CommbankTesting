using CommbankTesting.Pages;
using CommbankTesting.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace CommbankTesting
{
    public class VerifyTravelMoneyOverseas 
    {
        IWebDriver driver;
        [SetUp]
        public void LaunchCommbankPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.commbank.com.au/");        }
           
        [TestCase]
        public void NavigateToTravelProduct()
        {
            CommbankLaunchPage launchPage = new CommbankLaunchPage((RemoteWebDriver)driver);
            launchPage.ClickOnTravelProductLink();
            TravelProductPage travelPage = new TravelProductPage((RemoteWebDriver)driver);
            travelPage.VerifyTravelMoneySubset();
            travelPage.VerifySubLinks();
            NetbankLogon logonPage = new NetbankLogon((RemoteWebDriver)driver);
            logonPage.ClickOnLogon();
            logonPage.VerifyUsernameAndPassword();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Dispose();
        }
    }
}