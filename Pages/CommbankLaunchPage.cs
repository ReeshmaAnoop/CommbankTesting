using CommbankTesting.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        private IWebElement travelMoneyButton => _driver.FindElementByLinkText("Travel products");
        private IWebElement announcemetDismissButton => _driver.FindElementByLinkText("Dismiss");
        public void ClickOnTravelProductLink()
        {
            Actions actions = new Actions(_driver);
            actions.MoveToElement(travelMoneyButton).Perform();
            //To close the bushfire announcement popup as it hides travelMoneyButton      
            if (announcemetDismissButton.Displayed)
            {
                Click(announcemetDismissButton);
            }
            Click(travelMoneyButton);
        }
    }
}