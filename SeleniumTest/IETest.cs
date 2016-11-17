using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using OpenQA.Selenium.IE;

namespace SeleniumTest
{
    [TestClass]
    public class IETest : BaseBrowserClass
    {
        public IETest() : base(new InternetExplorerDriver())
        {

        }

        [TestMethod]
        public override void SearchOnGoogle()
        {
            base.SearchOnGoogle();
        }
    }
}
