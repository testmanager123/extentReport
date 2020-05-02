
using NUnit.Framework;
using SeleniumFBExtentreport.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFBExtentreport.Test
{
    class PassScenario : BaseClass

        {

            [Test]
            public void PassTest()
            {
                driver.Url = "http://www.facebook.com";
                Assert.AreEqual(driver.Title, "Facebook");
            }
        }
}
