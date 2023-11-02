using My_Selenium_C_.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Pages
{
    public class MainPage:BasePage
    {
        public MainPage(Driver driver)
            :base(driver)
        {
        }
        protected override string Url => "https://the-internet.herokuapp.com/";

        private Element FormAuthenticationLink => Driver.FindElement(By.LinkText("Form Authentication"));

        public void ClickFormAuthenticationLink()
        {
            FormAuthenticationLink.Click();
        }
    }
}
