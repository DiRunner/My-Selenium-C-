using My_Selenium_C_.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Selenium_C_.Pages;
using OpenQA.Selenium.Edge;
using NUnit.Framework;

namespace My_Selenium_C_.Tests
{
    [TestFixture]
    public class FormAuthenticationTest:BaseTest
    {

        private static MainPage _mainPage;
        private static LoginPage _loginPage;
        
        [SetUp]
        protected void Initialize()
        {
            _mainPage = new MainPage(Driver);
            _loginPage = new LoginPage(Driver);
        }
        
        [Test]
        public void LoginWithValidUser()
        {
            _mainPage.Open();
            _mainPage.ClickFormAuthenticationLink();
            _loginPage.UserLogin("tomsmith", "SuperSecretPassword!");
            Thread.Sleep(1000);
            
            var LoginMessage = Driver.FindElement(By.Id("flash"));

            Thread.Sleep(1000);
            Assert.True(LoginMessage.Text.Contains("You logged into a secure area!"));
        }        
    }
}
