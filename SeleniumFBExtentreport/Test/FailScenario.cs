using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFBExtentreport.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFBExtentreport.Test
{
    class FailScenario : BaseClass

        {
            [Test]
            public void FailTest()
            {
                driver.Url = "http://www.facebook.com";
                Assert.AreEqual(driver.Title, "mytest");
            }
        }
}
