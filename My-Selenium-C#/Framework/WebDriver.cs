using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Framework
{
    public class WebDriver:Driver
    {
        private IWebDriver _webDriver;
        private WebDriverWait _webDriverWait;

        public override void Start (Browser browser)
        {
            switch(browser)
            {
                case Browser.Chrome:
                    _webDriver = new ChromeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Firefox:
                    _webDriver = new FirefoxDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Edge:
                    _webDriver = new EdgeDriver(Environment.CurrentDirectory);
                    break;
                case Browser.Safari:
                    _webDriver = new SafariDriver(Environment.CurrentDirectory);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _webDriverWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(30));
        }

        public override void Quit()
        {
            _webDriver.Quit();
        }

        public override void GoToUrl(string url)
        {
            _webDriver.Navigate().GoToUrl(url); 
        }

        public override string Url => _webDriver.Url;
        public override Element FindElement(By locator)
        {
            IWebElement nativeWebElement = _webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementExists(locator));
            Element element = new WebElement(_webDriver, nativeWebElement, locator);
            Element logElement = new logElement(element);

            return logElement;
        }

        public override List<Element> FindElements (By locator)
        {
            IReadOnlyCollection<IWebElement> nativeWebElements = _webDriverWait.Until(SeleniumExtras
                .WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            var elements = new List<Element>();
            foreach (var nativeWebElement in nativeWebElements)
            {
                Element element = new WebElement(_webDriver, nativeWebElement, locator);
                elements.Add(element);
            }

            return elements;
        }
    }
}
