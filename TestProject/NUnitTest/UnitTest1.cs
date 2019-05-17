using NUnit.Framework;
//using ServiceProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
namespace Tests
{
    public class Tests
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //Sushrut: Assignment1
        public void TestChromeTest()
        {
            driver = new ChromeDriver(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://Google.com");
            driver.Close();
        }
        public void TestIETest()
        {
            driver = new InternetExplorerDriver(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://Google.com");
            driver.Close();


        }

        public void TestEdgeTest()
        {
            driver = new EdgeDriver(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://Google.com");
            driver.Close();


        }
        [Test]
        public void Test1FireFoxTest()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://shop.demoqa.com");
            driver.Manage().Window.Maximize();
            //   driver.FindElement(By.ClassName("noo-search")).Click();
            //   driver.FindElement(By.Id("yith-wcwl-popup-message")).Click();
            //driver.FindElement(By.XPath("//a[contains(text(),'My Wishlist')]")).Click();
            //driver.FindElement(By.LinkText("My Account")).Click();
            //Sushrut: Assignment2:use href in xpath
            driver.FindElement(By.XPath("//a[contains(@href,'https://shop.demoqa.com/')]")).Click();
            //Sushrut: Assignment3:Find locator from multiple tags having same type
            IList<IWebElement> element = driver.FindElements(By.TagName("a"));
            foreach (IWebElement web in element)
            {
                if (web.Text.Contains("My Account"))
                {
                    web.Click();
                    break;
                }
            }
            driver.Close();

        }
        [Test]
        public void findXpath()
        {
            
        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://shop.demoqa.com");
            driver.Manage().Window.Maximize();
            //Using OR & AND
            driver.FindElement(By.XPath("//*[@id='nav-menu-item-cart' or@class='menu-item noo-menu-item-cart minicart']")).Click();
            driver.FindElement(By.XPath("//*[@type='button' and @class='btn-navbar noo_icon_menu icon_menu']"));

            driver.FindElement(By.XPath("//div[starts-with(@id,'cbox')]"));

            driver.FindElement(By.XPath("//a[text='My Wishlist']"));

            driver.FindElement(By.XPath("//*[@class='pull-right noo-topbar-right']//following::li[4]"));

            driver.Close();
        }

        [Test]
        //dipti:Assignment1 
        public void webdriver_commands()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);
            driver.Url = "https://Store.DemoQA.com";

            String PageTitle = driver.Title;
            Console.WriteLine("Page_Title: " + PageTitle);

            int TitleLength = driver.Title.Length;
            Console.WriteLine("TitleLength : " + TitleLength);

            String PageURL = driver.Url;
            Console.WriteLine("PageURL: " + PageURL);

            int PageUrlLength = driver.Url.Length;
            Console.WriteLine("PageUrlLength : " + PageUrlLength);

            String PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            Console.WriteLine("PageSourceLength: " + PageSourceLength);

            driver.Close();
        }
        [Test]
        // Dipti: Assignment2
        public void navigate_commands()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);

            driver.Navigate().GoToUrl("https://DemoQA.com");
            driver.FindElement(By.XPath(".//*[@id=’menu-item-374′]/a")).Click();
            //  driver.FindElement(By.XPath(".//*[@id=’menu-item-374′]/a")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();

            driver.Navigate().GoToUrl("https://Store.DemoQA.com");
            driver.Navigate().Refresh();
            driver.Close();

        }
        //Vrushali:Assignment1
          public void radio()
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
                driver = new FirefoxDriver(service);
                driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");

                IWebElement radiobutton1 = driver.FindElement(By.Id("sex-0"));
                radiobutton1.Click();
                String RadioButtonName = radiobutton1.GetAttribute("name");
                Console.WriteLine(RadioButtonName);
                String RadioButtonValue = radiobutton1.GetAttribute("value");
                Console.WriteLine(RadioButtonValue);
                IWebElement radiobutton2 = driver.FindElement(By.Id("sex-1"));
                String RadioButtonName1 = radiobutton1.GetAttribute("name");
                Console.WriteLine(RadioButtonName1);

              }
              [Test]
        public void checkbox()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
            driver = new FirefoxDriver(service);
            driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");

            IWebElement checkBox1 = driver.FindElement(By.Id("profession-0"));
            checkBox1.Click();
            String checkBox1Name = checkBox1.GetAttribute("name");
            Console.WriteLine(checkBox1Name);
            String checkBox1Value = checkBox1.GetAttribute("value");
            Console.WriteLine(checkBox1Value);
            IWebElement checkBox2 = driver.FindElement(By.Id("profession-1"));
            String checkBox2Name = checkBox2.GetAttribute("name");
            Console.WriteLine(checkBox2Name);
            String checkBox2Value = checkBox1.GetAttribute("value");
            Console.WriteLine(checkBox2Value);
        }
         [Test]
         public void AlertDemo()
         {
             //public static void main(String[] args) throws NoAlertPresentException, InterruptedException
             FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\CSharpTrining\TestProject\NUnitTest\drivers");
             driver = new FirefoxDriver(service);
             driver.Navigate().GoToUrl("http://demo.guru99.com/test/delete_customer.php");
             driver.FindElement(By.Name("cusid")).SendKeys("12345");
             driver.FindElement(By.Name("submit")).Submit();
             IAlert alert = driver.SwitchTo().Alert();

             String alertMessage = driver.SwitchTo().Alert().Text;
             Console.WriteLine(alertMessage);
             alert.Accept();

         }
    }
}
