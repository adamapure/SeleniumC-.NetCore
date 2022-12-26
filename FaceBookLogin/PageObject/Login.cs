using FaceBookLogin.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static FaceBookLogin.Utilities.Hooks1;

namespace FaceBookLogin.PageObject
{
    class Login
    {
        public Login()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement email => driver.FindElement(By.XPath("//input[@name='email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@name='pass']"));

        IWebElement login => driver.FindElement(By.XPath("//button[@name='login']"));

        IWebElement notification => driver.FindElement(By.XPath("//a[@aria-label='Notifications, 4 unread']"));





        public void  EnterEmail()
        {
            email.SendKeys("8605227616");
        }
        public void EnterPassword()
        {
            password.SendKeys("Chetu@0707");
        }
        public void Clicklogin()
        {
            login.Click();
        }
        public bool IsNotificationDisplay()
        {
            return notification.Displayed;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
    }
}
