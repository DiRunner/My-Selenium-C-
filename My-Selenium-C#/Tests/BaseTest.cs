using My_Selenium_C_.Framework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace My_Selenium_C_.Tests
{
    public class BaseTest
    {
        private static readonly Driver LoggingDriver;
        
        static BaseTest()
        {
            LoggingDriver = new LoggingDriver(new WebDriver());
        }
        public BaseTest()
        {
           Driver = LoggingDriver;
        }
        public Driver Driver { get; set; }
        public TestContext TestContext { get; set; }
                
        [SetUp]
        protected void Init()
        {
            Driver.Start(Browser.Firefox);            
        }

        [TearDown]
        public virtual void Cleanup() 
        {
            Driver.Quit();
        }

    }
}
