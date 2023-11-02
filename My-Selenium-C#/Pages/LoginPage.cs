using My_Selenium_C_.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Pages
{
    public class LoginPage:BasePage
    {
        public LoginPage(Driver driver)
            :base(driver)
        {
        }
        protected override string Url => "https://the-internet.herokuapp.com/login";
        private Element Username => Driver.FindElement(By.Id("username"));
        private Element Password => Driver.FindElement(By.Id("password"));
        private Element LoginButton => Driver.FindElement(By.ClassName("radius"));

        public void UserLogin(string username, string password)
        {
            Username.TypeText(username);
            Password.TypeText(password);
            LoginButton.Click();
        }       

    }
}
