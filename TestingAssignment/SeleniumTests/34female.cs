using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class T34female
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:62982/CalculatePremium.aspx";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void The34femaleTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/CalculatePremium.aspx");
            driver.FindElement(By.Id("TextBoxAge")).Clear();
            driver.FindElement(By.Id("TextBoxAge")).SendKeys("34");
            driver.FindElement(By.Id("TextBoxGender")).Clear();
            driver.FindElement(By.Id("TextBoxGender")).SendKeys("female");
            driver.FindElement(By.Id("BtnCalculate")).Click();
            Thread.Sleep(200);
            Assert.AreEqual("2.5", driver.FindElement(By.Id("LabelResult")).Text);
        }
        [Test]
        public void The7femaleTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/CalculatePremium.aspx");
            driver.FindElement(By.Id("TextBoxAge")).Clear();
            driver.FindElement(By.Id("TextBoxAge")).SendKeys("7");
            driver.FindElement(By.Id("TextBoxGender")).Clear();
            driver.FindElement(By.Id("TextBoxGender")).SendKeys("female");
            driver.FindElement(By.Id("BtnCalculate")).Click();
            Thread.Sleep(200);
            Assert.AreEqual("0", driver.FindElement(By.Id("LabelResult")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
