using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using OpenQA.Selenium.Remote;

namespace SeleniumTest
{
    [TestClass]
    public class BaseBrowserClass
    {
        private string browsername;

        protected IWebDriver driver;

        public BaseBrowserClass(IWebDriver driver)
        {
            this.driver = driver;

            ICapabilities capabilities = ((RemoteWebDriver)driver).Capabilities;

            this.browsername = capabilities.BrowserName;
        }

        [ClassInitialize]
        public void Init(TestContext context)
        {
        }

        [ClassCleanup]
        public void Cleanup()
        {
            if (driver != null)
                driver.Quit();
        }
        
        public virtual void SearchOnGoogle()
        {
            driver.Navigate().GoToUrl("http://www.google.com");

            var searchField = driver.FindElement(By.Id("lst-ib"));
            CaptureScreen(this.browsername + "-step1");

            searchField.SendKeys("teste");
            CaptureScreen(this.browsername + "-step2");

            searchField.SendKeys(Keys.Enter);
            CaptureScreen(this.browsername + "-step3");

        }

        public void CaptureScreen(string fileName)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(fileName + "_" + DateTime.Now.ToString("yyyy-mm-dd-HHmmss") + ".png", ImageFormat.Png);
        }
    }
}
