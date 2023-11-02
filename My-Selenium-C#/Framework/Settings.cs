using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Framework
{
    public class Settings
    {
        private static Driver _driver;
        public static Driver OpenBrowser()
        {
            _driver = new LoggingDriver(new WebDriver());
            _driver.Start(Browser.Firefox);
            return _driver;
        }
    }
}
