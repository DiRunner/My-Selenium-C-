using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace My_Selenium_C_.Framework
{
    public abstract class Element
    {
        public abstract By By {  get; }
        public abstract string Text { get; }
        public abstract bool? Enabled { get; }
        public abstract bool? Displayed { get; }
        public abstract void TypeText(string text);
        public abstract void SendKeys(string text);
        public abstract void Click();
        public abstract string GetAttribute(string attributeName);
    }
}
