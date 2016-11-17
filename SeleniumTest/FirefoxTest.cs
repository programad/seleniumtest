using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    [TestClass]
    public class FirefoxTest : BaseBrowserClass
    {
        public FirefoxTest() : base(new FirefoxDriver())
        {

        }

        [TestMethod]
        public override void SearchOnGoogle()
        {
            base.SearchOnGoogle();
        }
    }
}
