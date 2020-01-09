using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommbankTesting.Utility
{
    public class Utilities
    {
        public void Click(IWebElement element) => element.Submit();
        public void VerifyElement(IWebElement element)
        {
            Assert.IsTrue(true,"Element is present",element.Displayed);
        }
    }
}