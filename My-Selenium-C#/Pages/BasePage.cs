using My_Selenium_C_.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Selenium_C_.Pages
{
    public abstract class BasePage
    {
        protected readonly Driver Driver;

        protected BasePage(Driver driver)
        {
            Driver = driver;
        }

        protected abstract string Url { get; }

        public void Open()
        {
            Driver.GoToUrl(Url);
        }
    }
}
