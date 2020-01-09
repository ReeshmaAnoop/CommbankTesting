using CommbankTesting.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommbankTesting.Pages
{
    public class NetbankLogon : Utilities

    {
        RemoteWebDriver _driver;
        public NetbankLogon(RemoteWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement logonButton => _driver.FindElementByClassName("log-on-text");
        private IWebElement usernameTextBox => _driver.FindElementById("txtMyClientNumber_field");
        private IWebElement passwordTextBox => _driver.FindElementById("txtMyPassword_field");
        public void ClickOnLogon()
        {
            Click(logonButton);
        }
        public void VerifyUsernameAndPassword()
        {
            _driver.SwitchTo().Frame(0);
            VerifyElement(usernameTextBox);
            VerifyElement(passwordTextBox);
        }
    }
}