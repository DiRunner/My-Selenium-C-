using OpenQA.Selenium.DevTools.V116.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace My_Selenium_C_.Framework
{
    public abstract class Driver
    {
        public abstract void Start(Browser browser);
        public abstract void Quit();
        public abstract void GoToUrl(string url);
        public abstract string Url { get; }
        public abstract Element FindElement(By locator);
        public abstract List<Element> FindElements(By locator);
    }
}
