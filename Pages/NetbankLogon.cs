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
        private IWebElement LogonButton => _driver.FindElementByClassName("log-on-text");
        private IWebElement UsernameTextBox => _driver.FindElementById("txtMyClientNumber_label");
        private IWebElement PasswordTextBox => _driver.FindElementById("txtMyPassword_label");
        public void ClickOnLogon()
        {
            Click(LogonButton);       
        }
        public void VerifyUsernameAndPassword()
        {
            VerifyElement(UsernameTextBox);
            VerifyElement(PasswordTextBox);
        }
    }
}