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
            driver = new ChromeDriver("./Driver/");
            driver.Navigate().GoToUrl("https://www.commbank.com.au/");
            driver.Manage().Window.Maximize();
        }

        [TestCase]
        public void VerifyTravelProductAndNetbankLogon()
        {
            //Launch the Commmbank URL
            CommbankLaunchPage launchPage = new CommbankLaunchPage((RemoteWebDriver)driver);
            launchPage.ClickOnTravelProductLink();
            //Navigate to Travel Product page and Verify Sublinks
            TravelProductPage travelPage = new TravelProductPage((RemoteWebDriver)driver);
            travelPage.VerifyTravelMoneySubset();
            travelPage.VerifySubLinks();
            //Navigate to Logon Page and Veriy fields
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