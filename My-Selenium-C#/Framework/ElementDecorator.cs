﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Framework
{
    public abstract class ElementDecorator:Element
    {
        protected readonly Element Element;

        protected ElementDecorator(Element element)
        {
            Element = element;
        }

        public override By By => Element?.By;
        public override string Text => Element?.Text;
        public override bool? Enabled => Element?.Enabled;
        public override bool? Displayed => Element?.Displayed;
        public override void Click()
        {
            Element?.Click();
        }
        public override string GetAttribute(string attributeName)
        {
            return Element?.GetAttribute(attributeName);
        }
        public override void TypeText(string text)
        {
            Element.TypeText(text);
        }
        public override void SendKeys(string text)
        {
            Element.TypeText(text);
        }

    }
}
