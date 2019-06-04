using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;
        [SetUp]
        public void Initialize()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);
        }

        [Test]
        public void OpenTest()
        {

            driver.Url = "https://www.idempiere.org/test-sites";
            driver.Manage().Window.Maximize();
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            driver.FindElement(By.ClassName("dhtgD")).Click();
            string parentHandle = driver.CurrentWindowHandle;
            System.Threading.Thread.Sleep(2000);
            IList<string> lstWindow = driver.WindowHandles.ToList();
            foreach (var handle in lstWindow)
            {
                if (!handle.Equals(parentHandle))
                {
                    driver.SwitchTo().Window(handle);
                }

            }

            IWebElement Username = driver.FindElement(By.XPath("//input[@autocomplete='username']"));
            Username.SendKeys("admin @ gardenworld.com");

            IWebElement Password = driver.FindElement(By.XPath("//input[@autocomplete='current-password']"));
            Password.SendKeys("GardenAdmin");

            IWebElement RememberMe = driver.FindElement(By.XPath("//*[text()='Remember Me']"));
            RememberMe.Click();

            IWebElement okButton = driver.FindElement(By.XPath("//*[@type='button']"));
            okButton.Click();


            IWebElement searchResult1 = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            searchResult1.Click();
            IWebElement closeButton = fluentWait.Until(x => x.FindElement(By.XPath("//*[@title='Cancel']")));
            closeButton.Click();
            IWebElement searchResult2 = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            searchResult2.Click();

            IWebElement searchKey = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            searchKey.SendKeys("test");


            IWebElement Name = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            Name.SendKeys("Apurva Pandit");
            IWebElement Name2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            Name2.SendKeys("Apurva");
            IWebElement Description = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            Description.SendKeys("Assignment Test");
            IWebElement Reset = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/button[2]/img[1]"));
            Reset.Click();


            IWebElement searchKey1 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            searchKey1.SendKeys("test");

            Boolean text1 = false;
            IWebElement searchText = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            String textBox1 = searchText.text();
             if (searchText.text=="")
             {
                // Boolean text1 = true;
                Console.WriteLine("Text Field is empty");
             }

 
            IWebElement RefreshName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[2]/td[2]/div[1]/div[1]/input[1]"));
            RefreshName.SendKeys("Apurva Pandit");
            IWebElement RefreshName2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/div[1]/div[1]/input[1]"));
            RefreshName2.SendKeys("Apurva");
            IWebElement RefreshDescription = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[4]/td[2]/div[1]/div[1]/input[1]"));
            RefreshDescription.SendKeys("Assignment Test");
            IWebElement CheckMark = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/button[1]/img[1]"));
            CheckMark.Click();
            IWebElement newButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]"));
            newButton.Click();
            IWebElement BUName = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[3]/td[2]/input[1]"));
            BUName.SendKeys("Apurva");
            IWebElement BUCreditLimit = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[6]/td[4]/div[1]/input[1]"));
            BUCreditLimit.SendKeys("5000");
            IWebElement BUSave = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[6]/span[1]/img[1]"));
            BUSave.Click();

        }
        [TearDown]
        public void CloseTest()
        {
            // driver.Close();
        }
    }
}