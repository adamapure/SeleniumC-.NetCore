using FaceBookLogin.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace FaceBookLogin.StepDefination
{
    [Binding]
    public class LogINFacebookSteps
    {

        Login login;
        public LogINFacebookSteps()
        {
            login = new Login();
        }









        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            login.Navigate();
        }
        
        [Given(@"I enter my Email Or Phone number")]
        public void GivenIEnterMyEmailOrPhoneNumber()
        {
            login.EnterEmail();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            login.EnterPassword();
        }
        
        [When(@"I clik on log in")]
        public void WhenIClikOnLogIn()
        {
            login.Clicklogin();
        }
        
        [Then(@"I log in successfully")]
        public void ThenILogInSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(login.IsNotificationDisplay);
        }
    }
}
