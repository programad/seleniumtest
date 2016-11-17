using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;

namespace SeleniumTest
{
    [TestClass]
    public class ChromeTest : BaseBrowserClass
    {
        public ChromeTest() : base(new ChromeDriver())
        {

        }

        [TestMethod]
        public override void SearchOnGoogle()
        {
            base.SearchOnGoogle();
        }
    }
}
