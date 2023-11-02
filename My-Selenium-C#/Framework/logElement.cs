using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Framework
{
    public class logElement : ElementDecorator
    {
        public logElement(Element element) : base(element)
        {
        }

        public override By By => Element?.By;

        public override string Text
        {
            get
            {
                Console.WriteLine($"Element Text = {Element?.Text}");
                return Element?.Text;
            }
        }

        public override bool? Enabled
        { 
            get 
            {
                Console.WriteLine($"Element Enabled = {Element?.Enabled}");
                return Element?.Enabled; 
            }
        }

        public override bool? Displayed
        {
            get
            {
                Console.WriteLine($"Element Displayed = {Element?.Displayed}");
                return Element?.Displayed;
            }
        }

        public override void Click()
        {
            Console.WriteLine($"Element Clicked");
            Element?.Click();
        }

        public override string GetAttribute(string attributeName)
        {
            Console.WriteLine($"Get Element's attribute = {attributeName}");
            return Element?.GetAttribute(attributeName);
        }

        public override void TypeText(string text)
        {
            Console.WriteLine($"Type Text = {text}");
            Element?.TypeText(text);
        }

        public override void SendKeys(string text)
        {
            Console.WriteLine($"Send Keys = {text}");
            Element?.SendKeys(text);
        }

    }
}
