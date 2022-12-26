using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions.Internal;

namespace FaceBookLogin
{
    public class Tests
    {
        public  IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            //  driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("8605227616");
            //  driver.FindElement(By.XPath("//input[@name='pass']")).SendKeys("Chetu@0707")
            // driver.FindElement(By.XPath("//button[@name='login']")).Click();
            // driver.FindElement(By.CssSelector("#login_link > div._xkt > a")).Click()
            IWebElement createnewAccount = driver.FindElement(By.CssSelector("#u_0_0_eI"));
            //  IWebElement element = driver.FindElement(By.Id("u_0_0_eI"));
            //  IWebElement element = driver.FindElement(By.XPath("//a[@id='u_0_0_eI']"));
            //IWebElement createAccountHeading = driver.FindElement(By.XPath("//span[@text()='create an account']"));
            //System.Threading.Thread.Sleep(5000);
            createnewAccount.Click();
            Assert.Pass();
        }
    }
}