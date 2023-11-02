using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V116.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Framework
{
    public class LoggingDriver: DriverDecorator
    {
        public LoggingDriver(Driver driver) : base(driver)
        {
        }

        public override void Start(Browser browser)
        {
            Console.WriteLine($"Start browser {Enum.GetName(typeof(Browser), browser)}");
            Driver?.Start(browser);
        }

        public override void GoToUrl(string url)
        {
            Console.WriteLine($"Go to URL = {url}");
            Driver?.GoToUrl(url);
        }

        public override string Url
        {
            get
            {
                Console.WriteLine($"Url = {Driver?.Url}");
                return Driver?.Url;
            }
        }

        public override Element FindElement(By locator)
        {
            Console.WriteLine("Find Element");
            return Driver?.FindElement(locator);
        }

        public override List<Element> FindElements(By locator)
        {
            Console.WriteLine("Find Elements");
            return Driver?.FindElements(locator);
        }
    }
}
